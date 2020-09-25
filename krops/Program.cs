using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту (H):");
                double H = double.Parse(Console.ReadLine());
                double S = (a + b) * H / 2;
                Console.WriteLine("Площадь трапеции:{0:F2}", S);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
