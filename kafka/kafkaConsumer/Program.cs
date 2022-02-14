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
            consumer.Init("10.0.42.12:33039");
            consumer.SetToEnd();
            consumer.GetMsg();

            Console.ReadKey();
        }
    }
}
