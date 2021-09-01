using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.EmailService
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string htmlMessage);
    }
}
