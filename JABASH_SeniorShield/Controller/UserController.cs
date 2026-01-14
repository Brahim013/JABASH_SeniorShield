using JABASH_SeniorShield.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JABASH_SeniorShield.Controller
{
    internal class UserController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SeniorShieldDbConn"].ConnectionString;

        public bool Registratie(string voornaam, string achternaam, string email, string wachtwoord, string emailMantelzorger)
        {
            string hashing = BCrypt.Net.BCrypt.HashPassword(wachtwoord);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblUsers (Voornaam, Achternaam, Email, GehashteWachtwoord, EmailMantelzorger) " +
                               "VALUES (@Voornaam, @Achternaam, @Email, @Hash, @EmailMantel)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Voornaam", voornaam);
                cmd.Parameters.AddWithValue("@Achternaam", achternaam);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Hash", hashing);
                cmd.Parameters.AddWithValue("@EmailMantel", emailMantelzorger);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fout bij opslaan in database: " + ex.Message);
                }
            }
        }

        public UserModel Login(string email, string wachtwoord)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, Voornaam, Achternaam, Email, GehashteWachtwoord FROM tblUsers WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string opgeslagenHash = reader["GehashteWachtwoord"].ToString();

                        if (BCrypt.Net.BCrypt.Verify(wachtwoord, opgeslagenHash))
                        {
                            return new UserModel
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Voornaam = reader["Voornaam"].ToString(),
                                Achternaam = reader["Achternaam"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Er is een probleem met de database connectie");
                }
            }
            return null;
        }


        public string GetMantelzorgerEmail(string emailSenior)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT EmailMantelzorger FROM tblUsers WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", emailSenior);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result?.ToString();
            }
        }

        public void VerstuurEchteMail(string naarEmail, string code)
        {
            var vanEmail = "jabashseniorshield@gmail.com";
            var appWachtwoord = "qomr rqkb uycc dfhq";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(vanEmail, appWachtwoord),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(vanEmail, "Jabash Senior Shield"),
                Subject = "HERSTELCODE: Hulp voor senior",
                Body = $"Beste mantelzorger,\n\nEr is een hulpvraag binnengekomen van een senior.\n" +
                       $"Geef de volgende herstelcode door zodat er een nieuw wachtwoord gekozen kan worden: {code}\n\n" +
                       "Met vriendelijke groet,\nHet Jabash Team",
                IsBodyHtml = false,
            };

            mailMessage.To.Add(naarEmail);
            smtpClient.Send(mailMessage);
        }

        public bool UpdateWachtwoord(string email, string nieuwWachtwoord)
        {
            string hashing = BCrypt.Net.BCrypt.HashPassword(nieuwWachtwoord);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblUsers SET GehashteWachtwoord = @Hash WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Hash", hashing);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
