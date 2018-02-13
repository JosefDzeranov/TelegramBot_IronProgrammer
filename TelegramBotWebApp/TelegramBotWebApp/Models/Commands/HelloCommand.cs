using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotWebApp.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name { get; } = "hello";
        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var replyToMessageId = message.MessageId;

            // To do logic

            client.SendTextMessageAsync(chatId, "josef", replyToMessageId: replyToMessageId);
        }
    }
}