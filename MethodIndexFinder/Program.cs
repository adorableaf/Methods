using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIndexFinder
{
    internal class Program
    {
        static void IndexFinder(int[,] Array, int ElementToFind)
        {
            
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (ElementToFind == Array[i, j])
                    {
                        Console.WriteLine("Индекс элемента: " + i + ", " + j);
                        return;
                    }
                }
            }

            Console.WriteLine("Элемент не найден!");
        }
        static void Main(string[] args)
        {
            int[,] SimpleArray = new int[4, 7];
            Random random = new Random();

            for (int i = 0; i < SimpleArray.GetLength(0); i++)
            {
                for (int j = 0; j < SimpleArray.GetLength(1); j++)
                {
                    SimpleArray[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < SimpleArray.GetLength(0); i++)
            {
                for (int j = 0; j < SimpleArray.GetLength(1); j++)
                {
                    Console.Write(SimpleArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("\nВыберите элемент массива, индекс которого хотите получить:\t");
            int WhatToFind = int.Parse(Console.ReadLine());

            IndexFinder(SimpleArray, WhatToFind);
        }
    }
}
