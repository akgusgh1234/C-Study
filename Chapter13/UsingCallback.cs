using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter13
{
    delegate int Compare(int a,int b);
    internal class UsingCallback
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbbleSort(int[] dataset, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < dataset.Length - 1; i++)
            {
                for (j = 0; j < dataset.Length - (i + 1); j++)
                {
                    if (Comparer(dataset[j], dataset[j + 1]) > 0)
                    {
                        temp = dataset[j + 1];
                        dataset[j + 1] = dataset[j];
                        dataset[j] = temp;
                    }
                }
            }
        }

            static void Main(string[] args)
            {
                int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbbleSort(array,new Compare(AscendCompare));
            for(int i=0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            }
    }
}
*/