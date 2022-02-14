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
            //producer.Init("192.168.31.229:9092");
            producer.Init("10.0.42.12:33039");
            producer.SendMessage("test-topic","hello");

            Console.ReadKey();

            producer.UnInit();

        }
    }
}
