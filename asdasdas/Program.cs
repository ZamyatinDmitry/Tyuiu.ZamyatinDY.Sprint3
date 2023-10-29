using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x;
            for(x = 2; x <= 5; x++)
            {
                for(int d = 1; d <= x; d++)
                {
                    if(x % d == 0)
                    {
                        count ++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
