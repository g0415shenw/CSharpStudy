using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kafkaConsumer
{
    class Consumer
    {

        public IConsumer<Ignore, string> Con
        {
            get;
            set;
        }
        public void Init(string BootstrapServers = "192.168.31.229:9092",string Top= "test-topic")
        {
            var config = new ConsumerConfig {
                GroupId = "test-consumer-group2",
                AutoOffsetReset = AutoOffsetReset.Earliest,
                BootstrapServers = BootstrapServers };
            Con = new ConsumerBuilder<Ignore, string>(config).Build();

            Con.Subscribe(Top);

            


        }
        public void UnInit()
        {
            Con.Dispose();
        }
        public void  SetToEnd()
        {
            List<TopicPartition> listPar = new List<TopicPartition>();
            while(0 ==listPar.Count)
            {
                Con.Consume(100);
                listPar = Con.Assignment;
            }

            foreach(var item in listPar)
            {
                Console.WriteLine(item);
                Con.Seek(new TopicPartitionOffset(item, new Offset(Offset.End)));
            }
           
        }

        public void GetMsg()
        {
            while(true)
            {
                try
                {
                    var cr = Con.Consume(1000);
                    if(null == cr)
                    {
                        continue;
                    }
                    Console.WriteLine($"Consumed message '{cr.Message.Value}' at: '{cr.TopicPartitionOffset}'.");
                }
                catch (ConsumeException e)
                {
                    Console.WriteLine($"Error occured: {e.Error.Reason}");
                }
            }
          

        }
    }
}
