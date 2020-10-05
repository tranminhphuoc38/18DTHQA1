using System;
using System.Threading.Tasks;

namespace asyn_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData1();
            GetData2();
            Console.Read();
        }

        static void GetData1()
        {
            Console.WriteLine("Method 1 started");
            Console.WriteLine(GetResult("Method 1 completed", 2000));
        }

        static void GetData2()
        {
            Console.WriteLine("Method 2 started");
            Console.WriteLine(GetResult("Method 2 completed", 4000));
        }

        static string GetResult(string msg, int threadTime)
        {
            System.Threading.Thread.Sleep(threadTime);
            return msg;

        }
    }
}
