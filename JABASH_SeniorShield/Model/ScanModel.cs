using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JABASH_SeniorShield.Model
{
    internal class ScanModel
    {
        public string Afzender { get; set; }
        public string Inhoud { get; set; }
        public int Score { get; set; }
        public DateTime ScanDatum { get; set; }

        public ScanModel(string afzender, string inhoud, int score)
        {
            Afzender = afzender;
            Inhoud = inhoud;
            Score = score;
            ScanDatum = DateTime.Now;
        }
    }
}
