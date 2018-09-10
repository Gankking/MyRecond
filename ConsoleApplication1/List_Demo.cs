using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class List_Demo
    {
        public void show()
        {
            //List 列表，也是一个数组，是一个泛型的；也是变长的，没有装箱拆箱
            {
                Console.WriteLine("******************List<T>*****************");
                List<int> intLsit = new List<int>();
                intLsit.Add(123);
                intLsit[1] = 456;
                intLsit.RemoveAt(4);

                List<string> stringList = new List<string>();
                stringList[0] = "abc";
            }
        }
    }
}
