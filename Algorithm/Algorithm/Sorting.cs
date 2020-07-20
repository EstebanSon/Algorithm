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

        public static int[] MergeSort(int[] data)
        {
            int half = data.Length / 2;
            int top = data.Length - half;
            int bot = data.Length - top;

            for(int i = 0; i < data.Length; i += 2)
            {
                if(data[i+1] < data[i])
                {
                    int temp = data[i+1];
                    data[i+1] = data[i];
                    data[i] = temp;
                }
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
