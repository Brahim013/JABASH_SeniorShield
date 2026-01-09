using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using JABASH_SeniorShield.Model;

namespace JABASH_SeniorShield.Controller
{
    internal class UserController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SeniorShieldDbConn"].ConnectionString;

        public UserModel Login(string email, string wachtwoord)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, Voornaam, Achternaam, Email, GehashteWachtwoord FROM tblUsers WHERE Email = @Email AND GehashteWachtwoord = @Wachtwoord";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Tegen SQL Injecties voor Cyber Security adviezen
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
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
                catch
                {
                    throw new Exception("Er is een probleem met de database connectie");
                }

                return null;
            }
        }
    }

}
