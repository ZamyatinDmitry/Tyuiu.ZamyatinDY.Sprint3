﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZamyatinDY.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                for(int y = 1;y<=x; y++)
                {
                    if(x % y == 0)
                    {
                        res += y;
                    }
                }
            }
            return res;
        }
    }
}
