using EasyNetQ;
using EasyNetQ.Topology;
using System.Configuration;

namespace com.example.utility.RabbitMq
{
    public static partial class RabbitMqConfig
    {
        // RabbitMQ连接字符串
        private static readonly string connectionString = ConfigurationManager.AppSettings["rabbitConnectionString"];

        // EasyNetQ提供的amqp协议下的公共API
        public static readonly IAdvancedBus advancedBus = RabbitHutch.CreateBus(connectionString).Advanced;

        /// <summary>
        ///  初始化配置
        /// </summary>
        public static void Init()
        {
            InitTestConfig();
        }

        private static void InitTestConfig()
        {
            // 1.交换机
            exchange_liugang_test = advancedBus.ExchangeDeclare(exchangeName, x => x.WithType(ExchangeType.Direct));
            // 2.队列
            queue_liugang_test = advancedBus.QueueDeclare(queueName, x => x.AsDurable(true));
            // 3.绑定
            advancedBus.Bind(exchange_liugang_test, queue_liugang_test, routingKey);
        }

    }
}

