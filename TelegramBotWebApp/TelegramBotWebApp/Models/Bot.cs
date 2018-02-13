using System.Collections.Generic;
using Telegram.Bot;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using TelegramBotWebApp.Models.Commands;

namespace TelegramBotWebApp.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandList;

        public static IReadOnlyList<Command> Commands => commandList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
                return client;

            commandList = new List<Command>();

            commandList.Add(new HelloCommand());
            commandList.Add(new KipaCommand());

            // to do add other command

            client = new TelegramBotClient(AppSettings.Key);

            var hook = string.Format(AppSettings.Url, "api/message/update");
            //await client.SetWebhookAsync(hook, null, 10, new[] { UpdateType.MessageUpdate });
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}