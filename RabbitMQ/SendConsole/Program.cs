using System;
using RabbitMQ.Client;
using System.Text;

namespace SendConsole
{
    class Program
    {
        static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var con = factory.CreateConnection())
            {
                using (var channel = con.CreateModel())
                {
                    channel.QueueDeclare(queue: "");
                }
            }
        }
    }
}
