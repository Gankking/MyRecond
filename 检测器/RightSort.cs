using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//<---------使用的时候，在这里引用加入程序的所在空间+类--------->
using 排序; 

namespace 检测器
{
    //对数器
    public class RightSort
    {
        public void Init(int length,int size)
        {
            Random rd = new Random();
            //int Rangs = rd.Next(1, 10);//(生成1~10之间的随机数，不包括10,"左闭右开"1~9)
            //int Rangs2 = rd.Next(10);//0~10-1 = 0~9
            int times = 10;
            bool isRight = true;
            List<int[]> ErrorArrList = new List<int[]>();

            for (int t = 0; t < times; t++)
            {
                int randomLenght = rd.Next(length);
                int[] intArry = new int[randomLenght+1];
                for (int i = 0; i <= randomLenght; i++)
                {
                    intArry[i] = rd.Next(1,size+1);
                }
                //数组是引用类型，你把a附给了b,那么a和b就是指向堆内存中的同一个内容
                //排序一个当然会影响另一个
                //int[] arr1 = intArry;
                int[] arr1 = (int[])intArry.Clone();//为系统排序准备的数组
                int[] arr2 = (int[])intArry.Clone();//为自定义排序准备的数组
                int[] arr3 = (int[])intArry.Clone();//为输出错误case做准备

                //系统排序
                Array.Sort(arr1);

                // <-------- 自定义排序 -------->
                bubbleSort.Run(arr2);

                //比较两个数组
                isRight= Comparer(arr1, arr2);

                if (!isRight)
                    break;
            }
            //打印不能正确完成排序工作的数组
            if (!isRight)
                foreach (int[] erl in ErrorArrList)
                    printArray(erl);
            else
                Console.WriteLine("所有都Cese通过了，该排序方法OK");
            //等待
            Console.Read();
        }

        //比较排序后的数组，判断自定义排序是否有错
        public bool Comparer(int[]a,int []b)
        {
            bool result = true;
            for(int i =0;i<a.Length;i++)
            {
                if (a[i] == b[i]) continue;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        
        //打印数组
        public void printArray(int[] intArray)
        {
            foreach (var ia in intArray)
            {
                Console.Write(ia+"\t");
            }
            Console.WriteLine();
        } 
    }
}
