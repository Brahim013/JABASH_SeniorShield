using System;
using JABASH_SeniorShield.Security;
using JABASH_SeniorShield.Services;

namespace JABASH_SeniorShield.Testing
{
    public class PhishingTestRunner
    {
        public void Run()
        {
            var emailService = new MockEmailService();
            var analyzer = new PhishingAnalyzer();

            var inbox = emailService.GetInbox();

            foreach (var email in inbox)
            {
                var result = analyzer.Analyze(
                    email.Sender,
                    email.Subject,
                    email.Body,
                    email.Links,
                    email.Attachments
                );

                Console.WriteLine($"Afzender: {email.Sender}");
                Console.WriteLine($"Risico: {result.RiskLevel}");
                Console.WriteLine($"Score: {result.RiskScore}");

                foreach (var reason in result.Reasons)
                    Console.WriteLine("- " + reason);

                Console.WriteLine("-------------------------");
            }
        }
    }
}
