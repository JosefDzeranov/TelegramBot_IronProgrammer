using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotWebApp.Models.Commands
{
    public class KipaCommand : Command
    {
        public override string Name { get; } = "kipa";
        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var replyToMessageId = message.MessageId;

            // To do logic

            var text = @"Я с каждым днем тебя сильней люблю,
И за тебя судьбу благодарю,
Не знаю, как жилось мне до тебя,
Жизнь была скучной у меня.

Ну а теперь в ней смысл есть,
И это вовсе и не лесть,
Ты моя нежность, ты любовь моя,
Так много значишь для меня!
♥
Люблю тебя кипа кипа!!!
";
            client.SendTextMessageAsync(chatId, text, replyToMessageId: replyToMessageId);
        }
    }
}