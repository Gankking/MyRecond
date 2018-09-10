using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ArrayList_Demo
    {
        public void show()
        {
            //动态数组，可变长度的数组，不限制类型；先分配一段内存，扩展可以动态增加内存；但是数据不安全，不一致，可能用错
            //装箱 一切元素都是object  值类型会装箱
            {
                Console.WriteLine("******************ArrayList*****************");
                ArrayList arrayList = new ArrayList();
                arrayList.Add("Eleven");
                arrayList.Add("is");
                arrayList.Add(31);
                arrayList[4] = 26;
                arrayList.RemoveAt(4);
            }
        }
    }
}
