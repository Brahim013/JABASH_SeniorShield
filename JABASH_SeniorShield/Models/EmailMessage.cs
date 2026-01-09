using System.Collections.Generic;

namespace JABASH_SeniorShield.Models
{
    public class EmailMessage
    {
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public List<string> Links { get; set; } = new List<string>();
        public List<string> Attachments { get; set; } = new List<string>();
    }
}
