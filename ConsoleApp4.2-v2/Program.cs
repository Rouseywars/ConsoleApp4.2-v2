using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._2_v2
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 8, m = 8, sum1 = 0, sum2 = 0;
                /*
                Console.WriteLine("Введите n-столбцов и m-строк!"); //8 и 5
                Console.Write("n=");
                n = int.Parse(Console.ReadLine());
                Console.Write("m=");
                m = int.Parse(Console.ReadLine());
                */
                Console.WriteLine();

                int[,] k = new int[n, m];
                Random r = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        k[i, j] = r.Next(-5, 10);
                        Console.Write("{0} ", k[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < n; i++) //столбец
                {
                    for (int j = 0; j < m; j++)
                    {
                            sum2 += k[j, i];
                    }
                    if (i == 1)
                    Console.WriteLine("Сумма " + (i + 1) + " столбца равна " + sum2);
                    sum2 = 0;
                }

                for (int i = 0; i < n; i++) //строка
                {
                    for (int j = 0; j < m; j++)
                    {
                            sum1 += k[i, j];
                    }
                    if (i == 2)
                    Console.WriteLine("Сумма " + (i + 1) + " строки равна " + sum1);
                    sum1 = 0;
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
