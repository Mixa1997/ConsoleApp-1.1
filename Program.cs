using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий
            try
            {
                double F, b, x, z, a;
                Console.Write("Введите b:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Введите x:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Введите z:");
                z = double.Parse(Console.ReadLine());
                Console.Write("Введите a:");
                a = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Blue;
                F = Math.Cos((b * x, 5)) - ((Math.Sin(a * a) + Math.Cos(((x, 3) + (z, 5) - (a * a)))) / (Math.Asin(a * a) + Math.Acos((x, 7) + (a * a))));
                Console.WriteLine("F=" + F);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
