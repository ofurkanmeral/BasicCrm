using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CrmWebUi.EmailService
{
    public class SendMail : IEmailService
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;
        public SendMail(string host,int port,bool enableSSL,string userName,string password)
        {
            this._host = host;
            this._port = port;
            this._enableSSL = enableSSL;
            this._userName = userName;
            this._password = password;
        }
        public Task SendEmail(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(this._userName, email, subject, htmlMessage)
                {
                    IsBodyHtml = true
                }
                );
        }
    }
}
