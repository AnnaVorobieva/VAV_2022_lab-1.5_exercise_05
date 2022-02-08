using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        /* Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN
следующего вида:
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1 */

        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер массива: ");
            n = Convert.ToInt32(Console.ReadLine());
                        
            int[,] x = new int[n, n];
                        
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Заполняем элементы массива
                    // По условию x[0,0], x[0,2], x[0,4],..., x[1,1], x[1,3]т.д. равны 1
                    // x[0,1], x[0,3], x[0,5],..., x[1,0], x[1,2]т.д. равны 0
                    // Заметим - если для элемента сумма индексов i+j четная, элемент равен 0, если нет, элемент равен 1
                    // Проверка на четность - если остаток от деления (i+j)  на 2 равен 1 - сумма нечетная, иначе четная

                    if ((i + j) % 2 == 1) // проверка остатка от деления  (i+j) на 2, равен ли он 1
                    {
                        x[i, j] = 0;

                    }
                    else
                    {
                        x[i, j] = 1;
                    }

                }

            }

            Console.WriteLine("Весь массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", x[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
