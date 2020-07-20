using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random rand = new Random();

            for(int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(10) + 1;
                for (int j = 0; j < i; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        i--;
                    }

                    
                }
            }

            //string value = Console.ReadLine();
            Debug.WriteLine("Before");
            for(int k = 0; k < 10; k++)
            {
                Debug.WriteLine(arr[k]);
            }

            // 선택정렬
            //Sorting.SelectionSort(arr);

            // 삽입정렬
            //Sorting.InsertSort(arr);

            // 버블정렬
            Sorting.BubbleSort(arr);

            Debug.WriteLine("After");
            for (int k = 0; k < 10; k++)
            {
                Debug.WriteLine(arr[k]);
            }
        }
    }
}
