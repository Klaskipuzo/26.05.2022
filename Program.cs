// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            













        }

        static void dzifI1_1()
        {
            //I1.1. Рассчитать значение у при заданном значении х:
            // y = sin(x) при x> 0 или y = cos(x) в противном случае.

            Console.WriteLine("Введите значение Х");
            var x = Convert.ToInt32(Console.ReadLine());
            double y;

            if (x >= 0)
            {
                y = (double)Math.Sin(x);
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void dzA1_1()
        {
            //A1.1. Дано расстояние в сантиметрах. Найти число полных метров в нем.
            Console.WriteLine("Введите расстояние в сантиметрах");

            var sm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Расстояние в метрах :" + sm / 1000);
        }

        static void dzA1_2()
        {
            //A1.2. Дана масса в килограммах. Найти число полных центнеров в ней
            Console.WriteLine("Введите сколько киллограм весит ваш автомобиль");

            var car = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Полное число целых центнеров вашего авто: " + car / 100);
        }

        static void dzMetanitArray1()
        {
            //{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}};
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
            var a = mas.GetUpperBound(0);
            var b = mas.GetUpperBound(1);
            var c = mas.GetUpperBound(2);


            Console.Write("{");
            for (int i = 0; i <= a; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= b; j++)
                {
                    Console.Write("{");
                    for (int d = 0; d <= c; d++)
                    {
                        Console.Write(mas[i, j, d]);

                        if (d < c)
                            Console.Write(" , ");
                    }
                    Console.Write("}");
                    if (j < b)
                        Console.Write(" , ");

                }
                Console.Write("}");
                if (i < c)
                    Console.Write(" , ");

            }
            Console.Write("}");

        }


        
    }
}