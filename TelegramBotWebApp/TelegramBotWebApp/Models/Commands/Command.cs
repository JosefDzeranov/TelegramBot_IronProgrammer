using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotWebApp.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            return command.Contains(Name);
        }
    }
}