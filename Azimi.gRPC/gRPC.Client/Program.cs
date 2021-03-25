using Grpc.Net.Client;
using GrpcService.Server;
using System;
using System.Threading.Tasks;

namespace gRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //create chanel
            using var chanel = GrpcChannel.ForAddress("https://localhost:5001");

            //create client
            var client = new Greeter.GreeterClient(chanel);

            var reply = await client.SayHelloAsync(new() { Name = "amir" });

            Console.WriteLine($"reply : {reply.Message} ");
            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }
    }
}
