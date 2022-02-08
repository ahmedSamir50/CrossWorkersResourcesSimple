using System.Collections.Generic;

namespace EmailService
{
    public class Email
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public List<Recipient> Recipients { get; set; }
    }
}
