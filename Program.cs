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
        
        static void les0()
        {
            int[,] myArray = new int[,]
            {
                {1,2,3,4,5, },
                {2,3,4,423,43},
                { 5,4,3,2,1},
                {5,234,3,2,2 },
                { 3,4,5,6,7},
            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void les1()
        {
            int[,] myArray = new int[10, 6];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(0, 100);
                }

            }



            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void les3()
        {
            string[,] myArray = new string[2, 3];



            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: " + j);
                    myArray[i, j] = Console.ReadLine();
                }

            }



            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void dzC1_1()
        {

            //C1.1. Напечатать ряд чисел 20 в виде:

            //20 20 20 20 20 20 20 20 20 20.

            int num = 20;
            for (int i = 0; i < 10; i++)
            {
                for (int j = num; j <= 20; j++)
                {
                    Console.Write(j + " ");
                }
            }
        }

        static void dzC1_2()
        {
            //C1.2. Составить программу вывода любого числа любое заданное число раз в виде, аналогичном показанному в предыдущей задаче.
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                for (int j = num; j <= num; j++)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }

        static void dzMetanitfor1()
        {
            /*C1.3.Напечатать «столбиком»:
            а) все целые числа от 20 до 35;
            б) квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            в) третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            г) все целые числа от a до b(значения a и b вводятся с клавиатуры; b < a).*/


            /* (a)
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            */

            /* (b)
            var b = int.Parse(Console.ReadLine());

            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
            */

            /* (v)
            var a = int.Parse(Console.ReadLine());

            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(i * i * i);
            }
            */
            Console.WriteLine("Введите дипазон чисел");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void dzMetanitfor2()
        {

        }


    }
}