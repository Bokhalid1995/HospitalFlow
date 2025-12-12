
using HospitaFlow.Application.Interfaces.Common;
using Microsoft.Extensions.Configuration;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        // Example using SMTP
        var smtpHost = _configuration["EmailConfiguration:SmtpHost"];
        var smtpPort = int.Parse(_configuration["EmailConfiguration:SmtpPort"]!);
        var smtpUser = _configuration["EmailConfiguration:SmtpUser"] ;
        var smtpPass = _configuration["EmailConfiguration:SmtpPass"];

        using var client = new System.Net.Mail.SmtpClient(smtpHost, smtpPort)
        {
            Credentials = new System.Net.NetworkCredential(smtpUser, smtpPass),
            EnableSsl = true
        };

        var mail = new System.Net.Mail.MailMessage(smtpUser, to, subject, body);
        await client.SendMailAsync(mail);
    }
}
