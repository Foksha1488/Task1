using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Введите элементы:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент{i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            Console.WriteLine("Массив в обратномпорядке:");
            foreach (int element in array)
            {
                Console.Write(element + "");
            }
            Console.ReadKey();
        }
    }
}
