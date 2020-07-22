using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Sorting
    {
        public static int[] SelectionSort(int[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                for(int j = i + 1; j < data.Length; j++)
                {
                    if(data[i] > data[j])
                    {
                        int temp = data[j];
                        data[j] = data[i];
                        data[i] = temp;
                    }
                }
            }
            return data;
        }

        public static int[] InsertSort(int[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(data[i] < data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            return data;
        }

        public static int[] MergeSort(int[] data, int init, int end)
        {
            if (init >= end)
                return data;

            int mid = end - 1 / 2;
            MergeSort(data, init, mid);
            MergeSort(data, mid + 1, end);

            int num1 = mid + 1 - init;
            int num2 = end - mid;

            int[] left = new int[num1], right = new int[num2];

            for (int i = 0; i < num1; i++)
                left[i] = data[init + i];


            for (int i = 0; i < num2; i++)
                right[i] = data[mid + i];

            int j = 0, z = 0;
            int k = init;

            while(z < num1 && j < num2)
            {
                if(left[z] <= right[num2])
                {
                    data[k] = left[z];
                    z++;
                    k++;
                }
                else
                {
                    data[k] = right[j];
                    j++;
                    k++;
                }
            }

            while(j< num1)
            {
                data[k] = left[z];
                z++;
                k++;
            }

            while(j < num2)
            {
                data[k] = right[j];
                j++;
                k++;
            }

            return data;
        }

        public void SortingFunc(int[] init, int[] end)
        {

        }

        public static int[] BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 1, k = 0; j < data.Length; j++, k++)
                {
                    if (data[j] < data[k])
                    {
                        int temp = data[j];
                        data[j] = data[k];
                        data[k] = temp;
                    }
                }
            }

            return data;
        }
    }
}
