using MailKit.Net.Smtp;
using MimeKit;

namespace GameStore.BLL.Services.EmailService
{
    /// <summary>
    /// Сервис по отправке письм на электронную почту
    /// </summary>
    public class EmailService : IEmailService
    {
        /// <summary>
        /// Отправка письм на электронную почту
        /// </summary>
        /// <param name="userEmail">Email пользователя</param>
        /// <param name="subject">Тема письма</param>
        /// <param name="message">Сообщение</param>
        public async Task SendEmailAsync(string userEmail, string subject, string message)
        {
            MimeMessage emailMessage = new();
            emailMessage.From.Add(new MailboxAddress("GameStore", "deelimpay@mail.ru"));
            emailMessage.To.Add(new MailboxAddress("", userEmail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };

            using (SmtpClient client = new())
            {
                try
                {
                    //Временное решение (вызывает дыру в безопасности)
                    client.CheckCertificateRevocation = false;
                    await client.ConnectAsync("smtp.mail.ru", 465, true);
                    await client.AuthenticateAsync("deelimpay@mail.ru", "uRAxchK0veqpTnjPkMcJ");
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                }
            }
        }
    }
}
