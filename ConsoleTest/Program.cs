using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                //string s = $"{i*i}";
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
