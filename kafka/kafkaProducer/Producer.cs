using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafkaProducer
{
    class Producer
    {
        string BootstrapServers
        {
            get;
            set;
        }

        private IProducer<Null, string> Pro
        {
            get;
            set;
        }
        //192.168.31.229:9092
        public void Init(string BootstrapServers = "192.168.31.229:9092")
        {
            var config = new ProducerConfig { BootstrapServers = BootstrapServers };
            Pro = new ProducerBuilder<Null, string>(config).Build();
        }
        public void UnInit()
        {
            Pro.Flush(TimeSpan.FromSeconds(10));
            Pro.Dispose();
        }

        public async void SendMessage(string top,string msg)
        {
            var Message = new Message<Null, string> { Value = msg};
            try
            {
                var dr = await Pro.ProduceAsync(top, Message);
                Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
            }
        }
    }
}
