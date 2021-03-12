using EasyNetQ;

namespace com.example.utility.RabbitMq
{
    /// <summary>
    /// 消息消费者接口
    /// </summary>
    public interface IConsumerMessageHandler
    {
        /// <summary>
        /// 自动确认
        /// </summary>
        /// <param name="body"></param>
        /// <param name="properties"></param>
        /// <param name="receivedInfo"></param>
        void Handle(byte[] body, MessageProperties properties, MessageReceivedInfo receivedInfo);
    }
}
