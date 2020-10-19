using System;
using System.Threading;
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

        static async void GetData1()
        {
            Console.WriteLine("Method 1 started");
            Console.WriteLine(await GetResultAsync("Method 1 completed", 4000));
        }

        static async void GetData2()
        {
            Console.WriteLine("Method 2 started");
            Console.WriteLine(await GetResultAsync("Method 2 completed", 6000));
        }

        static Task<string> GetResultAsync(string msg, int threadTime)
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(threadTime);
                return msg;
            });
        }
    }
}
