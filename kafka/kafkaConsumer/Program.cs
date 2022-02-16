using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafkaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumer consumer = new Consumer();
            consumer.Init("192.168.31.229:9092","NBG");
            consumer.SetToEnd();
            consumer.GetMsg();

            Console.ReadKey();
        }
    }
}
