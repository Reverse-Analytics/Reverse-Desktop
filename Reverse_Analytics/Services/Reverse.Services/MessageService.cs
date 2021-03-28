using Reverse.Services.Interfaces;

namespace Reverse.Services
{
    public class MessageService : IMessageService
    {
        public string GetLoginErrorMessage() =>
            "Указаны неверные учётные данные.";

        public string GetWelcomeMessage() =>
            "Добро пожаловать в мороженный магнат";
    }
}
