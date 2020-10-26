using System;

namespace Algorithms.Order
{
    public class BubbleSort
    {

        public BubbleSort()
        {

            int[] arr = new int[11] { 1,4,10,3,2,5,0,7,8,9,6 };

            OrderByArrayAsc(arr);

            Console.WriteLine(string.Join(", ", arr));
            Console.ReadKey();
        }

        private void OrderByArrayAsc(int[] array)
        {
            for (int i = array.Length; i > 0; i--)
            {
                for (int ii = 0; ii < array.Length-1; ii++)
                {
                    if (array[ii] > array[ii + 1])
                    {
                        var temp = array[ii];
                        array[ii] = array[ii + 1];
                        array[ii + 1] = temp;
                    }
                }
            }
        }

        private void OrderByArrayDesc(int[] array)
        {
            for (int i = array.Length; i > 0; i--)
            {
                for (int ii = 0; ii < array.Length - 1; ii++)
                {
                    if (array[ii] < array[ii + 1])
                    {
                        var temp = array[ii];
                        array[ii] = array[ii + 1];
                        array[ii + 1] = temp;
                    }
                }
            }
        }

    }
}
