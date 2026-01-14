using JABASH_SeniorShield.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JABASH_SeniorShield.Controller
{
    internal class ScanController
    {

        public void OpslaanScanResultaat(ScanModel scan)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SeniorShieldDbConn"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tblPhishingControles (Afzender, Inhoud, RisicoScore, Datum) VALUES (@Afzender, @Inhoud, @Score, @ScanDatum)";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Afzender", scan.Afzender);
                    cmd.Parameters.AddWithValue("@Inhoud", scan.Inhoud);
                    cmd.Parameters.AddWithValue("@Score", scan.Score);
                    cmd.Parameters.AddWithValue("@ScanDatum", scan.ScanDatum);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
