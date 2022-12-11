using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;

namespace Hypance.Services.TelegramApi
{
    public static class TelegramApiConfig
    {
        static ITelegramBotClient Bot = new TelegramBotClient("5155431848:AAEloUrGxV90epvgF31XegNmwI9oTljQYXw");

        public static async Task Main()

        {
            
            using var cts = new CancellationTokenSource();
            var reveiverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()

            };
            Bot.StartReceiving(updateHandler, pollingErrorHandler, reveiverOptions);
        }
        public static async Task SendMessage(string message)
        {
            
            Message sentMessage = await Bot.SendTextMessageAsync(
              chatId: -723963123,
             text: message
            );
        }



        private static async Task updateHandler(ITelegramBotClient Bot, Update update, CancellationToken cts)
        {
            var chatId = update.Message.Chat.Id;
            Message sentMessage = await Bot.SendTextMessageAsync(
              chatId: chatId,
             text: "HELLO",
            cancellationToken: cts);
        }

        private static Task pollingErrorHandler(ITelegramBotClient Bot, Exception ex, CancellationToken cts)
        {
            var ErrorMessage = ex switch
            {
                ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => ex.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }


    }

}