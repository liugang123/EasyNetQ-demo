using com.example.consumer.Reciever;
using com.example.utility.RabbitMq;
using EasyNetQ;
using System;

namespace com.example.consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化RabbitMQ配置
            RabbitMqConfig.Init();
            // 设置消费者
            MessageReceiver receiver = new MessageReceiver();
            RabbitMqConfig.advancedBus.Consume(RabbitMqConfig.queue_liugang_test, receiver.Handle, x => x.WithPrefetchCount(1));

            Console.ReadLine();
        }
    }
}
