using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint3.Task0.V8.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint3.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнила: Шпилевая А. С. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле, при a = 0,25.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*      10                                                                 *");
            Console.WriteLine("*  p =  П  (a^k  + 1) * cos(4)                                            *");
            Console.WriteLine("*      k=1                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double a = 0.25;
            int startValue = 1;
            int stopValue = 10;


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"a = {a}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(a, startValue, stopValue));
            Console.ReadKey();

        }
    }
}
