using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rebro = Convert.ToInt32(Console.ReadLine());
            double v = Calc_v(rebro);
            double s = Calc_s(rebro);

            Console.WriteLine("Объем равен {0}", v);
            Console.WriteLine("Площадь равна {0}", s);
            Console.ReadKey();
        }

        static double Calc_v(int rebro)
        {
            double v = Math.Pow(rebro, 3);
            return v;
        }

        static double Calc_s(int rebro)
        {
            double s = (Math.Pow(rebro,2))*6;
            return s;
        }
    }
}
