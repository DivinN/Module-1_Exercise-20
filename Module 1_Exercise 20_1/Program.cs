using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, мы посчитаем длину окружности, площадь круга и объем сферы с таким радиусом.");
            double radius = Convert.ToDouble(Console.ReadLine());

            MyDelegete myDelegete = CalcCircleLength;
            myDelegete += CalcCircleArea;
            myDelegete += CalcSphereVolume;
            myDelegete.Invoke(radius);

            Console.ReadKey();
        }

        delegate double MyDelegete(double R);
        public static double CalcCircleLength(double R)
        {
            double result = 2 * Math.PI * R;
            Console.WriteLine(result);
            return result;
        }
        public static double CalcCircleArea(double R)
        {
            double result = Math.PI * R * R;
            Console.WriteLine(result);
            return result;
        }
        public static double CalcSphereVolume(double R)
        {
            double result = 4 * Math.PI * R * R * R / 3;
            Console.WriteLine(result);
            return result;
        }

    }
}
