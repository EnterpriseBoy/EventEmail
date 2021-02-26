using FluentEmail.Smtp;
using FluentEmail.Core;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;

namespace EventEmail.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        public async Task SendEmailAsync(Models.Email email1)
        {
            var sendder = new SmtpSender(() => new SmtpClient(host: "LocalHost")
            {
                Host="smtp.zoho.com",
                EnableSsl = true,
                DeliveryMethod= SmtpDeliveryMethod.Network,
                Port=465,
                Credentials = new NetworkCredential("niallirl@zoho.com","Nimag101!")
            });

            Email.DefaultSender = sendder;

            var email = await Email
                .From("niall.maguire@zoho.com")
                .To("niall.maguire@topmail.ie", name: "Niall")
                .Subject("Have a great day")
                .Body("Thank you for right now")
                .SendAsync();
        }
    }
}
