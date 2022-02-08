using System;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    // just mocked Email service 
    public class MockedEmailService : IEmailService
    {
        public async Task SendEmail(Email email, Action callback)
        {
            await Task.Run(() =>
            {
                StringBuilder strb = new();
                if (email.Recipients.Count > 0)
                    email.Recipients.ForEach(rs => { strb.Append(rs.RecipientEmail+","); });
                Console.WriteLine("EMAIL SENT TO {0} {1}", strb,email.Subject );
                callback();
            });
        }
    }
}
