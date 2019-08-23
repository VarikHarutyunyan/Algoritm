using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = items[temp];

            }
        }

        public static void QuickSort(int[] items)
        {
            Quicksorted(items, 0, items.Length - 1);
        }

        private static void Quicksorted(int[] items, int left, int right)
        {
            Random _pivotRng = new Random();

            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);

                int newPivot = Partition(items, left, right, pivotIndex);
            }
        }

        private static int Partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }
            
            Swap(items, storeIndex, right);
            return storeIndex;
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8, 12, 19, 2, 0 };

            QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
