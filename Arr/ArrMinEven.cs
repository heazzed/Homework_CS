using System;

namespace SixthTask
{
    class ArrayMinEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве: ");
            int amountElems = int.Parse(Console.ReadLine());

            int[] myArray = new int[amountElems];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nМассив заполнен!");

            int min = myArray[0];

            Console.WriteLine("\nВывод элементов массива: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nВывод элементов массива в обратном порядке: ");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            int sumEven = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sumEven += myArray[i];
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }

            Console.WriteLine("\nСумма четных элементов: " + sumEven);

            Console.WriteLine("\nМинимальный элемент: " + min);

            Console.ReadLine();
        }
    }
}