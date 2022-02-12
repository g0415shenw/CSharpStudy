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
            consumer.Init();
            consumer.SetToEnd();
            consumer.GetMsg();

            Console.ReadKey();
        }
    }
}
