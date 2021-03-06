using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighthTask
{
    class ArrayMethods
    {
        static void Resize<T>(ref T[] arr, int newLength)
        {
            T[] newArr = new T[newLength];
            for (int i = 0; i < arr.Length && i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void PushBack(ref int[] arr, int newElement)
        {
            int[] newArr = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            arr[arr.Length-1] = newElement;
        }

        static void PushFront(ref int[] arr, int newElement)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i+1] = arr[i];
            }
            arr = newArr;
            arr[0] = newElement;
        }

        static void PushByIndex(ref int[] arr, int indexOfElement, int newElement)
        {
            int[] newArr = new int[arr.Length + 1];
            newArr[indexOfElement] = newElement;
            for (int i = 0; i < indexOfElement; i++)
            {
                newArr[i] = arr[i];
            }            
            for (int i = indexOfElement+1; i <= arr.Length; i++)
            {
                newArr[i] = arr[i-1];
            }
            arr = newArr; 
        }

        static void AddFirst(ref int[] arr, int newElement)
        {
            PushByIndex(ref arr, 0, newElement);
        }

        static void AddLast(ref int[] arr, int newElement)
        {
            PushByIndex(ref arr, arr.Length, newElement);
        }

        static void PopBack(ref int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void PopFront(ref int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i+1];
            }
            arr = newArr;
        }

        static void PopByIndex(ref int[] arr, int indexOfElement)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < indexOfElement; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = indexOfElement; i < newArr.Length; i++)
            {
                newArr[i] = arr[i+1];
            }
            arr = newArr;
        }

        static void DeleteFirst(ref int[] arr)
        {
            PopByIndex(ref arr, 0);
        }

        static void DeleteLast(ref int[] arr)
        {
            PopByIndex(ref arr, arr.Length-1);
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
           
            Console.WriteLine();

            //Resize(ref myArray, 19);

            //PushBack(ref myArray, 4);
            //PushFront(ref myArray, 20);

            //PushByIndex(ref myArray, 4, -5);

            //AddFirst(ref myArray, 5);
            //AddLast(ref myArray, 5);

            //PopBack(ref myArray);
            //PopFront(ref myArray);

            //PopByIndex(ref myArray, 6);

            //DeleteFirst(ref myArray);
            //DeleteLast(ref myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
