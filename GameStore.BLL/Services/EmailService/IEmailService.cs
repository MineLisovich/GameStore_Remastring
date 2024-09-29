namespace GameStore.BLL.Services.EmailService
{
    /// <summary>
    /// Интерфейс сервиса EmailService. Отправка письм на электронную почту
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Отправка письм на электронную почту
        /// </summary>
        /// <param name="userEmail">Email</param>
        /// <param name="subject">Тема сообщения</param>
        /// <param name="message">Сообщение</param>
        Task SendEmailAsync(string userEmail, string subject, string message);
    }
}
