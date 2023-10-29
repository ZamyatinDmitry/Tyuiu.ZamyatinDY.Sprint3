using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZamyatinDY.Sprint3.Task6.V15.Lib;
namespace Tyuiu.ZamyatinDY.Sprint3.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Замятин Д. Ю. | ИИПб 23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Замятин Дмитрий Юрьевич | ИИПб 23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Напишите программу, которая ищет среди целых чисел,            *");
            Console.WriteLine("* принадлежащих числовому отрезку [6, 15] сумму всех делителей            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 6;
            int stopValue = 15;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine();
        }
    }
}
