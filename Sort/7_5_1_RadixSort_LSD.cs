using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class _7_5_1_RadixSort_LSD
    {
        public void print(int[] a, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(a[i]+"\t");
            }
            Console.WriteLine();
        }

        //获得最大数的位数，2位数或者3位等
        public int GetBit(int [] a, int len)
        {
            int[] Bit = { 1, 10, 100, 1000, 10000 };
            int ArrBit;
            int max = 0;
            for (int i = 0; i < len; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            int num = max, j = 0;
            while (num / 10 != 0)
            {
                num = num / 10;
                ++j;
            }
            ArrBit = Bit[j];
            return ArrBit;
        }

        //基数排序主要函数
        public void RadixSort(int [] a, int len)
        {
            int bit = GetBit(a, len);
            int [,]temp = new int[len,10];
            int n = 0;
            int i, j;
            for(int b = 1; b<=bit;b=b*10)
            {
                //分配
                for(i = 0;i<len;i++)
                {
                  n = (a[i]/b)%(10); //取某位上的数，先除后余，先将数置于个位，再用%10
                  temp[i,n] = a[i];
                }
                //回收
                n = 0;
                for(j=0;j<10;j++) //列-桶，数字--桶的编号0-9,所以列为10
                {
                    for(i=0;i<len;i++)//行，层，待比较的数组长度
                    {
                        if(temp[i,j]!=0){
                            a[n++] = temp[i,j];
                            temp[i,j]=0; //temp二维表换出去后，相关位置要置00000，方便下次记录使用
                        }
                    }
                }
                Console.WriteLine("Proccess: ");
                print(a, len);
            }
        }
    }
}
