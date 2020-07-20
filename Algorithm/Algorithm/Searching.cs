using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Searching
    {
        public static int LinearSearch(int[] arr, int nLength, int value)
        {
            int rtValue = 0;

            for(int i = 0; i < nLength; i++)
            {
                if (arr[i] == value)
                    rtValue = i;
            }

            return rtValue;
        }

        public static int BinarySearch(int[] arr, int init, int end, int value)
        {
            int rtValue = -1;

            if(end >= 1)
            {
                int mid = (end + 1) / 2;
                if (arr[mid] == value)
                    return rtValue= mid;

                if (arr[mid] > value)
                    return BinarySearch(arr, init, mid - 1, value);

                return BinarySearch(arr, mid + 1, end, value);
            }
            return rtValue;
        }
    }
}
