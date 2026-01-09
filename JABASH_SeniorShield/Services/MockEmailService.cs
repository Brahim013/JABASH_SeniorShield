using System.Collections.Generic;
using JABASH_SeniorShield.Models;

namespace JABASH_SeniorShield.Services
{
    public class MockEmailService
    {
        public List<EmailMessage> GetInbox()
        {
            return new List<EmailMessage>
            {
                // 🟢 Veilige mail
                new EmailMessage
                {
                    Sender = "dochter@familie.nl",
                    Subject = "Foto’s van het weekend",
                    Body = "Hier zijn de foto's van afgelopen zondag!"
                },

                // 🟡 Verdachte mail
                new EmailMessage
                {
                    Sender = "info@rab0bank-alerts.com",
                    Subject = "Controleer uw rekening",
                    Body = "Wij hebben ongebruikelijke activiteit gedetecteerd.",
                    Links = { "https://rab0bank-alerts.com/login" }
                },

                // 🔴 Phishing mail
                new EmailMessage
                {
                    Sender = "bank@gmail.com",
                    Subject = "URGENT: Uw rekening is geblokkeerd",
                    Body = "Klik direct op de link om uw account te herstellen.",
                    Links = { "http://192.168.1.1/login" },
                    Attachments = { "factuur.html" }
                }
            };
        }
    }
}
