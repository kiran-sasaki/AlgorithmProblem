using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Sorting()
        {
            int[] arr = { 99,65,86,76,34 };
            int temp;

            for (int j = 1; j <= arr.Length - 1; j++)
            {
                for (int i = 0; i <= arr.Length -2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted : ");
            foreach (int p in arr)
                Console.WriteLine(p + " ");
        }
    }
}
