using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public static class bubbleSort
    {
        public static void Run(int[] arr)
        {
            int len = arr.Length;
            for(int i=0;i< len - 1;i++)
            {
                for (int j = 1; j< len-i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    } 
}
