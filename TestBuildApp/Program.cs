using System;
using System.Threading;

namespace TestBuildApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Started " + DateTime.Now.ToString());

            for(int i =0; i < 10; i++)
            {
                Console.WriteLine("Processing: " + i + " - " + DateTime.Now.ToString());
                Thread.Sleep(3000);
            }

            Console.WriteLine("App Completed " + DateTime.Now.ToString());
        }
    }
}
