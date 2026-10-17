using System.Net;
using System.Net.Mail;

namespace Friendzone.Core.Email;

public class Sender
{
    private readonly SmtpClient smtpClient;

    public Sender(Endpoint endpoint, Credentials credentials, bool enableSsl = true)
    {
        smtpClient = new SmtpClient(endpoint.Host, endpoint.Port)
        {
            Credentials = new NetworkCredential(
                credentials.Username,
                credentials.Password
            ),
            EnableSsl = enableSsl
        };
    }

    public void Send(string to, string subject, string body)
    {
        smtpClient.Send(
            new MailMessage("no-reply@friendzone.dev", to, subject, body)
        );
    }
}
