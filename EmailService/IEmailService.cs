using System;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailService
    {
        Task SendEmail(Email email , Action callback);
    }
}
