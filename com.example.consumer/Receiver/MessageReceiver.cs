
using com.example.consumer.Models;
using com.example.utility.RabbitMq;
using EasyNetQ;
using Newtonsoft.Json;
using System;
using System.Text;

namespace com.example.consumer.Reciever
{
    public class MessageReceiver : IConsumerMessageHandler
    {
        public void Handle(byte[] body, MessageProperties properties, MessageReceivedInfo receivedInfo)
        {
            string messageText = Encoding.UTF8.GetString(body);
            MessageModel messageModel = JsonConvert.DeserializeObject<MessageModel>(messageText);
            Console.WriteLine("consumer handler message:" + messageModel.Content);
        }
    }
}
