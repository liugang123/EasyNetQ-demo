using EasyNetQ.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.example.utility.RabbitMq
{
    public static partial class RabbitMqConfig
    {
        public static readonly string exchangeName = "exchange.liugang.test";
        public static readonly string queueName = "queue.liugang.test";
        public static readonly string routingKey = "route.liugang.test";

        public static IExchange exchange_liugang_test;
        public static IQueue queue_liugang_test;
    }
}
