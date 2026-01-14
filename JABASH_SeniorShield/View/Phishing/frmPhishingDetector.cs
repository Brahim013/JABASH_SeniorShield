using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;

namespace JABASH_SeniorShield.View
{
    public partial class frmPhishingDetector : Form
    {
        public frmPhishingDetector()
        {
            InitializeComponent();
        }

        private async void btnControleren_Click(object sender, EventArgs e)
        {
            string afzender = txtAfzender.Text.ToLower();
            string mailInhoud = txtMail.Text.ToLower();
            int risicoScore = 0;

            risicoScore += CheckAfzender(afzender, mailInhoud);

            var phishingWoorden = new Dictionary<string, int>
            {
                { "direct", 15 }, { "nu", 10 }, { "spoed", 20 }, { "vandaag", 10 },
                { "geblokkeerd", 25 }, { "boete", 20 }, { "achterstand", 15 },
                { "inloggen", 15 }, { "verifiëren", 20 }, { "klik hier", 20 },
                { "belastingdienst", 20 }, { "cjib", 20 }, { "pakket", 10 }
            };

            foreach (var item in phishingWoorden)
            {
                if (mailInhoud.Contains(item.Key))
                {
                    risicoScore += item.Value;
                }
            }

            // Links uit de mailinhoud halen
            var gevondenLinks = Regex.Matches(txtMail.Text, @"(http|https)://[^\s]+");

            foreach (Match overeenkomst in gevondenLinks)
            {
                // Opvragen van risicoScore vanuit de API
                int apiScore = await CheckUrlViaIPQS(overeenkomst.Value);

                // Vergelijken met eigen scores en aanhouden van de hogere score uit de API als dat zo is
                if (apiScore > risicoScore)
                {
                    risicoScore = apiScore;
                }
            }

            // Maximaal 100 maken qua punten
            if (risicoScore > 100)
            {
                risicoScore = 100;
            }

            ToonResultaat(risicoScore);
        }

        private void ToonResultaat(int score)
        {
            txtResultaatTekst.Text = $"Risico Score: {score}%!";

            if (score < 30)
            {
                pnlResultaat.BackColor = Color.Green;
            }
            else if (score >= 30 && score < 60)
            {
                pnlResultaat.BackColor = Color.Orange;
            }
            else
            {
                pnlResultaat.BackColor = Color.Red;
            }
        }

        private async Task<int> CheckUrlViaIPQS(string url)
        {
            string apiKey = "aFmYroFAzFe3E9cFWCSuDRQPWNJv86y5";
            string encodedUrl = Uri.EscapeDataString(url);
            string requestedUrl = $"https://www.ipqualityscore.com/api/json/url/{apiKey}/{encodedUrl}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonResponse = await client.GetStringAsync(requestedUrl);

                    // Alleen risicoScore uit de IPQS website halen
                    var gevondenGetal = Regex.Match(jsonResponse, "\"risk_score\":(\\d+)");
                    if (gevondenGetal.Success)
                    {
                        return int.Parse(gevondenGetal.Groups[1].Value);
                    }
                    return 0;
                }
                catch
                {
                    return 0;
                }
            }
        }

        private int CheckAfzender(string afzender, string mailInhoud)
        {
            afzender = afzender.ToLower();
            mailInhoud = mailInhoud.ToLower();
            int extraRisico = 0;

            if ((afzender.Contains("ing") || afzender.Contains("rabobank") || afzender.Contains("belasting"))
                && (afzender.Contains("@gmail.com") || afzender.Contains("@outlook.com") || afzender.Contains("@hotmail.com")))
            {
                return 100;
            }

            if ((mailInhoud.Contains("ing") || mailInhoud.Contains("rabobank") || mailInhoud.Contains("belasting"))
                && (afzender.Contains("@gmail.com") || afzender.Contains("@outlook.com") || afzender.Contains("@hotmail.com")))
            {
                extraRisico += 60;
            }

            if (afzender.EndsWith(".top") || afzender.EndsWith(".xyz"))
            {
                extraRisico += 40;
            }

            return extraRisico;
        }

        private void frmPhishingDetector_Load(object sender, EventArgs e)
        {

        }

        private void btnAfzender_Click(object sender, EventArgs e)
        {
            txtAfzender.Clear();
        }

        private void btnMailInhoud_Click(object sender, EventArgs e)
        {
            txtMail.Clear();
        }
    }
}
