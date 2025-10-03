using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proektPOwkole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чилса массива");
            string[] input_arr= Console.ReadLine().Split();

            int[] arr = new int[input_arr.Length]; //исходный массив.
            for (int i = 0; i < input_arr.Length; i++)
            {
                if (!int.TryParse(input_arr[i], out arr[i]))
                {
                    Console.WriteLine("Error");
                }
            }

            Console.Clear();
            int arrMax = arr.Max();
            Console.WriteLine($"Найден максимальный элемент! -> {arrMax}");
            int[] aux = new int[arrMax+1]; // вспомогательный массив.
            Console.WriteLine("Создан вспомогательный массив");

            for (int e = 0; e<arr.Length; e++)
            {
                aux[arr[e]]++;
            }
            int b = 0;
            for (int j = 0; j < arrMax+1; j++)
            {
                for (int k=0; k < aux[j]; k++)
                {
                    arr[b] = j;
                    b++;
                }
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
