using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            double length = circle.GetLength(r);
            double area = circle.GetArea(r);
           Console.WriteLine($"Длина окружности { length}\n Площадь круга { area}" );
            Console.WriteLine("Введите координаты центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double point = circle.BelongPoint(x0,y0,x, y);
            if (point<r)
                Console.WriteLine("Точка принадлежит кругу");
            else//иначе
                Console.WriteLine("Точка не принадлежит кругу");
            Console.ReadKey();
        }
    }
}
