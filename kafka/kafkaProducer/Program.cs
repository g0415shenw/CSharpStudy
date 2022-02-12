using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new Producer();
            producer.Init("192.168.31.229:9092");

            producer.SendMessage("test-topic","hello");

            Console.ReadKey();

            producer.UnInit();

        }
    }
}
