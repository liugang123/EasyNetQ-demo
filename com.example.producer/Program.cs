using com.example.producer.Models;
using com.example.producer.Sender;
using com.example.utility.RabbitMq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.example.producer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.初始化rabbit配置
            RabbitMqConfig.Init();

            // 2.消息生成者
            MessageSender sender = new MessageSender();

            // 3.发送消息
            Console.WriteLine("Input a messge to send");
            while (true)
            {
                string messageText = Console.ReadLine();
                if (messageText == "q")
                {
                    Console.WriteLine("send message quit");
                    break;
                }
                sender.SendMessage(new MessageModel() { Content = messageText });
                Console.WriteLine("send finish");
            }

            Console.ReadLine();
        }
    }
}
