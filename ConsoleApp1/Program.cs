using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 6;
            int d = 8;
            for (int i = 1;i < 4; i++)
            {
                a ++;
                b = a + c;
                c = b - a;
                d = (a + c) + i;
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
