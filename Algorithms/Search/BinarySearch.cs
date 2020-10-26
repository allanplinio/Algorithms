using System;

namespace Algorithms.Search
{
    public class BinarySearch
    {

        public BinarySearch()
        {

            var element = 340;
            int[] array = CreateArray();
            var position = Search(array, 0, array.Length, element);

            WriteResult(position, element);

            Console.ReadKey();
        }

        private int[] CreateArray()
        {
            var array = new int[10000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }
        
        private int Search(int[] array, int startPosition, int endPosition, int element)
        {
            if (startPosition <= endPosition)
            {
                var middle = (startPosition + endPosition) / 2;

                if (element > array[middle])
                {
                    return Search(array, middle + 1, endPosition, element); 
                }
                else if (element < array[middle])
                {
                    return Search(array, startPosition, middle - 1, element);
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        private void WriteResult(int position, int element)
        {
            if (position >= 0)
            {
                Console.WriteLine(string.Format("The element '{0}' was find at: {1} ", element, position));
            }
            else
            {
                Console.WriteLine(string.Format("The element '{0}' was not found.", element));
            }
        }
    }
}
