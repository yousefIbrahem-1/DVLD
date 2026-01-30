using System.Net;
using System.Net.Mail;
using System.Configuration;

public class EmailService
{
    public static void Send(string toEmail, string subject, string body)
    {
        string from = ConfigurationManager.AppSettings["EmailFrom"];
        string password = ConfigurationManager.AppSettings["EmailPassword"];

        var smtp = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(from, password),
            EnableSsl = true
        };

        var mail = new MailMessage
        {
            From = new MailAddress(from),
            Subject = subject,
            Body = body,
            IsBodyHtml = false
        };

        mail.To.Add(toEmail);

        smtp.Send(mail);
    }
}

