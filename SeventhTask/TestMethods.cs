using System;

namespace SeventhTask
{
    class TestMethods
    {
        static void Main(string[] args)
        {
            PrintLine('q', 2);

            Console.WriteLine();

            int[] _arr = { 2, 1, 3, 1 };
            Console.WriteLine(IndexOfElement(1, _arr));

            Console.ReadLine();
        }

        static void PrintLine(char symbol, uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol);
            }
        }

        static int IndexOfElement(int element, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
