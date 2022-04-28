using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace tg
{
    class Program
    {
        private static string token { get; set; } = "5222380705:AAGFM8dLcNyS2o2CN3BJ8vA0WHavtddgtM8";

        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);

            client.StartReceiving();

            client.OnMessage += OnMassegeHandler;

            Console.ReadLine();

            client.StopReceiving();
        }

        private static async void OnMassegeHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null) ;
            {
                Console.WriteLine($"Новое сообщение:{msg.Text}");
                await client.SendTextMessageAsync(msg.Chat.Id, msg.Text, replyToMessageId: msg.MessageId);
            }
        }
    }
}
