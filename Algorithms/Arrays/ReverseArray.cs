using System;

namespace Algorithms.Arrays
{
    public class ReverseArray
    {
        public ReverseArray()
        {
            int[] arr = new int[4] { 1, 4, 3, 2 };
            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", res));
            Console.ReadKey();
        }

        private int[] reverseArray(int[] a)
        {
            var newArray = new int[a.Length];

            var indexA = 1;
            for (var i = 0; i < newArray.Length; i++)
            {
                newArray[i] = a[a.Length - indexA];
                indexA++;
            }

            return newArray;
        }
    }
}
