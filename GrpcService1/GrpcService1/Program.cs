
using System;
using Grpc.Net.Client;
using GrpcService1;


namespace GrpcCLient
{
    class Program
    {
        static async Task Main(string[] args)
        {

                Console.WriteLine("press any key to cont...");
                Console.ReadLine();
                using var channel = GrpcChannel.ForAddress("https://localhost:5198");
            var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(new HelloRequest {Name="GreeterClient" });
            //Console.WriteLine($"Greetings: {reply.Message}");
            //Console.WriteLine("press any key to exit");
            //Console.ReadLine() ;
        }
    }
}