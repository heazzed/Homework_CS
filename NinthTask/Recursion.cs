using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthTask
{
    class Recursion
    {
        static void PrintArray(int[] array, int i = 0)
        {
            if (i<array.Length)
            {
                Console.WriteLine(array[i]);
                PrintArray(array, i + 1);
            }
        }

        static int SumArray(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;
            return array[i] + SumArray(array, i + 1);
        }
        static int SumOfDigit(int value)
        {
            if (value < 10)
                return value;
            return value % 10 + SumOfDigit(value / 10);
        }

        static int SumDigitsInArray(int[] array, int i = 0) // that's working for numbers from 0 to 99
        {
            if (i >= array.Length)
                return 0;
            int result=0;
            if (array[i] < 10)
            {
                result = array[i];
            }
            if (array[i] < 100 && array[i] > 9)
            {
                result = DivideToFDigit(array[i]) + DivideToLDigit(array[i]);
            }
            return result + SumDigitsInArray(array, i + 1);
        }

        static int DivideToFDigit(int num)
        {
            if (num / 10 == 0)
            {
                return num;
            }
            return DivideToFDigit(num / 10);
        }
        
        static int DivideToLDigit(int num)
        {
            if (num / 10 == 0)
            {
                return num % 10;
            }
            return DivideToLDigit(num % 10);
        }

        static void Main(string[] args)
        {
            int[] myArr = new int[5];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = i+11;
            }

            //PrintArray(myArr);

            //Console.WriteLine(SumArray(myArr));

            //Console.WriteLine(SumOfDigit(63551));

            //Console.WriteLine(SumDigitsInArray(myArr));

            Console.ReadLine();
        }
    }
}
