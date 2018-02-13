namespace TelegramBotWebApp.Models
{
    public static class AppSettings
    {
        /// <summary>
        ///     Ссылка на конечный опубликованный бот
        /// </summary>
        public static string Url { get; set; } = "https://iptelegrambotwebapp.azurewebsites.net:443/{0}";

        /// <summary>
        ///     Название контакта нашего бота
        /// </summary>
        public static string Name { get; set; } = "IronProgrammer_bot";


        /// <summary>
        ///     Ключ бота
        /// </summary>
        public static string Key { get; set; } = "503751329:AAGk9iEglxRqJraWRQvwZmBIRUR9v8yU-04";
    }
}