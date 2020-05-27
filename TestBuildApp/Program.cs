using System;
using System.Threading;

namespace TestBuildApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Begin Process " + DateTime.Now.ToString());
            Console.WriteLine("App Started " + DateTime.Now.ToString());

            for(int i =0; i < 10; i++)
            {
                Console.WriteLine("Processing: " + i + " - " + DateTime.Now.ToString());
                Thread.Sleep(3000);
                Console.WriteLine("Resume Process again for processing thread " + DateTime.Now.ToString());
            }

            Console.WriteLine("App Completed " + DateTime.Now.ToString());
        }
    }
}
