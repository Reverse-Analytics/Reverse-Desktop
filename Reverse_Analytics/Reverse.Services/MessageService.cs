namespace Reverse.Services
{
    public class MessageService
    {
        public string GetLoginErrorMessage() =>
            "Указаны неверные учётные данные.";

        public string GetWelcomeMessage() =>
            "Добро пожаловать в мороженный магнат";
    }
}
