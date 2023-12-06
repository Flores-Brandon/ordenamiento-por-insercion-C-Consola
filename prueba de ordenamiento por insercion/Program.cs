using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_de_ordenamiento_por_insercion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6 };

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(array);
            stopwatch.Stop();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("El tiempo de ejecucion  fue de = " + stopwatch.Elapsed);
            Console.ReadKey();
        }
        public static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Mover los elementos del array[0..i-1] que son mayores que key
                // a una posición adelante de su posición actual
                while (j >= 0 && array[j] < key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

        }
    }
}
