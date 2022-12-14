using RabbitMQ.Client;
using System;
using System.Text;

namespace RbProducer
{
    internal class Program
    {
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };


            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "queProdConsumer",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                int count = 0;
                while (true)
                {
                    string message = $"{count++} - Hello World!";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "queProdConsumer",
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                    System.Threading.Thread.Sleep(200);
                }
            }
        }
    }
}

