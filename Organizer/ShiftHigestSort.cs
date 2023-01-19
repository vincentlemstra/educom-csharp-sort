using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Organizer
{
    public class ShiftHighestSort
    {
        private List<int> array = new List<int>();

        /// <summary>
        /// Sort an array using the functions below
        /// </summary>
        /// <param name="input">The unsorted array</param>
        /// <returns>The sorted array</returns>
        public List<int> Sort(List<int> input)
        {
            array = new List<int>(input);

            SortFunction(0, array.Count - 1);
            return array;
        }

        /// <summary>
        /// Sort the array from low to high
        /// </summary>
        /// <param name="low">De index within this.array to start with</param>
        /// <param name="high">De index within this.array to stop with</param>
        private void SortFunction(int low, int high)
        {
            int n = high;
            for (int i = low; i <= high; i++)
            {
                for (int j = low; j <= n; j++)
                {
                    if ((j + 1) <= n)
                    {
                        if (array[j] > array[j + 1])
                        {
                            // swap index
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                n--;
            }
        }
    }
}
