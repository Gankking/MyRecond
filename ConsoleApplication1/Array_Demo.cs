using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Array_Demo
    {
        public void show()
        {
            //数组,不能扩展，分配在连续内存的;性能高，索性查找快，数据再多也没有影响；插入很慢，需要移动之后的数
            {
                Console.WriteLine("******************Array*****************");
                int[] intArray = new int[3];
                intArray[0] = 123;
                intArray[1] = 456;
                intArray[2] = 789;
                Array.Sort(intArray);
                Array.Reverse(intArray);//方法，反转

                string[] stringArray = new string[] { "123", "456", "789" };
            }
        }
    }
}
