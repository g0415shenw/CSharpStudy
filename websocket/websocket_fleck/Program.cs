using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websocket_fleck
{
    class Program
    {
        static void Main(string[] args)
        {

            var server = new WebSocketServer("ws://0.0.0.0:8181");
            server.Start(socket =>
            {
                socket.OnOpen = () => Console.WriteLine("Open!");
                socket.OnClose = () => Console.WriteLine("Close!");
                socket.OnMessage = (message) =>
                {
                    Console.WriteLine(message);
                    socket.Send(message);
                };
            });

            Console.ReadKey();

        }
    }
}
