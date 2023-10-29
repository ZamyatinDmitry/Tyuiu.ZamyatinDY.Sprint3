using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double sp = 0;
            int i = 0;
            for(x = -2; x <=2;x ++)
            {
                if (x == 0)
                {
                    continue;
                }
                sp = sp + (3*x - x);
                i++;
            }
            Console.WriteLine(sp);
            Console.ReadKey();
        }
    }
}
