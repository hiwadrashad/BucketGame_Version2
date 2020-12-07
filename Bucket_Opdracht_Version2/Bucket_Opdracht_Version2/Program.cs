using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.EventHandlers;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.StaticResources;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Bucket_Opdracht_Version2
{
    class Program
    {


        static void Main(string[] args)
        {
            //Program program = new Program();
            //BucketEventHandlers bucketEvent = new BucketEventHandlers();
            //bucketEvent.ExecutionEventHandler += new BucketEventHandlers.ExecutionDelegate(program.DoSomething);
            //bucketEvent.ExecutionEventHandler();
            //StaticEventHandlers.bucketEvent.ExecutionEventHandler += new EventHandlers.BucketEventHandlers.ExecutionDelegate(program.DoSomething);
            //StaticEventHandlers.bucketEvent.ExecutionEventHandler();
            //program.Something += new MyEventHandler(program.DoSomething);
            //program.Something -= new MyEventHandler(program.DoSomething);
            //program.Something();
            //IDataService item = MockDataService.GetMockDataService();
        
            Console.WriteLine(@"\______   \__ __   ____ |  | __ _____/  |_   /  _____/_____    _____   ____  ");
            Console.WriteLine(@" |    |  _/  |  \_/ ___\|  |/ // __ \   __\ /   \  ___\__  \  /     \_/ __ \ ");
            Console.WriteLine(@" |    |   \  |  /\  \___|    <\  ___/|  |   \    \_\  \/ __ \|  Y Y  \  ___/ ");
            Console.WriteLine(@" |______  /____/  \___  >__|_ \\___  >__|    \______  (____  /__|_|  /\___  >");
            Console.WriteLine(@"       \/            \/     \/    \/               \/     \/      \/     \/ ");
            Console.WriteLine(" ");
            Console.WriteLine("Generating a bucket");
            BucketEventHandlers iem = new BucketEventHandlers(new BucketEventHandlers());
            iem.AddBucket();

        }
    }
}
