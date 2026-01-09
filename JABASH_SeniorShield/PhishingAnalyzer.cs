using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace JABASH_SeniorShield.Security
{
    public class PhishingResult
    {
        public int RiskScore { get; set; }
        public string RiskLevel { get; set; } 
        public List<string> Reasons { get; set; } = new List<string>();
    }

    public class PhishingAnalyzer
    {
        private readonly List<string> UrgentWords = new List<string>
        {
            "direct", "onmiddellijk", "nu", "binnen 24 uur",
            "account geblokkeerd", "verificatie vereist"
        };

        private readonly List<string> DangerousExtensions = new List<string>
        {
            ".exe", ".zip", ".html", ".js", ".scr"
        };

        public PhishingResult Analyze(
            string senderEmail,
            string subject,
            string body,
            List<string> links,
            List<string> attachments)
        {
            int score = 0;
            var result = new PhishingResult();

            if (IsSuspiciousSender(senderEmail))
            {
                score += 25;
                result.Reasons.Add("De afzender is onbekend of verdacht.");
            }

            if (ContainsUrgentLanguage(subject + " " + body))
            {
                score += 20;
                result.Reasons.Add("De mail gebruikt dringende of dreigende taal.");
            }

            if (ContainsSuspiciousLinks(links))
            {
                score += 30;
                result.Reasons.Add("De mail bevat verdachte links.");
            }

            if (ContainsDangerousAttachments(attachments))
            {
                score += 40;
                result.Reasons.Add("De mail bevat mogelijk gevaarlijke bijlagen.");
            }

            score = Math.Min(score, 100);

            result.RiskScore = score;
            result.RiskLevel = DetermineRiskLevel(score);

            return result;
        }

        // ================= HELPER METHODS =================

        private bool IsSuspiciousSender(string sender)
        {
            return sender.EndsWith("@gmail.com") ||
                   sender.EndsWith("@hotmail.com") ||
                   sender.EndsWith("@outlook.com");
        }

        private bool ContainsUrgentLanguage(string text)
        {
            text = text.ToLower();
            return UrgentWords.Any(word => text.Contains(word));
        }

        private bool ContainsSuspiciousLinks(List<string> links)
        {
            foreach (var link in links)
            {
                if (Regex.IsMatch(link, @"https?:\/\/\d+\.\d+\.\d+\.\d+"))
                    return true;

                if (link.Contains("bit.ly") || link.Contains("tinyurl"))
                    return true;
            }
            return false;
        }

        private bool ContainsDangerousAttachments(List<string> attachments)
        {
            return attachments.Any(a =>
                DangerousExtensions.Any(ext => a.ToLower().EndsWith(ext)));
        }

        private string DetermineRiskLevel(int score)
        {
            if (score <= 30) return "Groen";
            if (score <= 70) return "Oranje";
            return "Rood";
        }
    }
}
