using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика3
{
    class Program
    {
        static void Main(string[] args)
        {
            double left = -100;
            double right = 100;
            bool okInput = false;
            double x = 0, y = 0;

            do
            {
                Console.WriteLine("Введите x:");
                try
                {
                    string buf = Console.ReadLine();
                    x = Convert.ToDouble(buf);
                    if (x >= left && x < right) okInput = true;
                    else
                    {
                        Console.WriteLine("Ошибка! -100 <= x <= 100");
                        okInput = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Не верно введено число!");
                    okInput = false;
                }
            } while (!okInput);

            do
            {
                Console.WriteLine("Введите y:");
                try
                {
                    string buf = Console.ReadLine();
                    y = Convert.ToDouble(buf);
                    if (y >= left && y < right) okInput = true;
                    else
                    {
                        Console.WriteLine("Ошибка! -100 <= y <= 100");
                        okInput = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Не верно введено число!");
                    okInput = false;
                }
            } while (!okInput);

            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) Console.WriteLine("Точка с координатами ({0} ; {1}) принадлежит заданному промежутку", x, y);
            else Console.WriteLine("Точка с координатами ({0} ; {1}) не принадлежит заданному промежутку", x, y);
            Console.ReadKey();
        }
    }
}
