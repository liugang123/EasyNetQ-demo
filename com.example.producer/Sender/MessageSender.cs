using com.example.producer.Models;
using com.example.utility.RabbitMq;
using EasyNetQ;
using EasyNetQ.Topology;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.example.producer.Sender
{
    class MessageSender
    {
        public static readonly IExchange exchange = RabbitMqConfig.exchange_liugang_test;
        public static readonly string routingkey = RabbitMqConfig.routingKey;

        public void SendMessage(MessageModel messageModel)
        {
            byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(messageModel));
            // messageProperties不能为null
            MessageProperties messageProperties = new MessageProperties();
            var task = RabbitMqConfig.advancedBus.PublishAsync(exchange, routingkey, false, messageProperties, body);
            task.Wait();
        }
    }
}
