using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double s = CalcS(a, b, c);

            double s1 = s;
            Console.WriteLine("Площадь первого  треугольника: {0}",s1);


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            s = CalcS(a, b, c);

            double s2 = s;
            Console.WriteLine("Площадь второго треугольника: {0}", s2);


            //сравниваем площади
            if (s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (s1 == s2)
                {
                    Console.WriteLine("Площади треугольников равны");
                }
                else
                {
                    if (s1 < s2)
                    {
                        Console.WriteLine("Площадь второго треугольника больше");
                    }
                }
            }

            Console.ReadKey();
        }

        //метод расчета площади
        static double CalcS(int a, int b, int c)
        {
            double p = (a+b+c)/2;
            double s = Math.Sqrt(p * (p - a)*(p-b)*(p-c));
            return s;
            
        }
    }
}
