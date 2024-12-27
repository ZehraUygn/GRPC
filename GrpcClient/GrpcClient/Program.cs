using Grpc.Net.Client;
using GrpcClient;

namespace GrpcCLient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("press any key to cont...");
            Console.ReadLine();
            using var channel = GrpcChannel.ForAddress("http://localhost:5044");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine($"Greetings: {reply.Message}");
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}