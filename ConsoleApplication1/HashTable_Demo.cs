using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HashTable_Demo
    {
        public void Init()
        {
            Console.WriteLine("******************HashTable*****************");
            Hashtable table = new Hashtable();
            table.Add("123","456");

            table[234] = 456; //key做个散列计算，得到一个地址
            //不同的key,可能得到同一个结果，储存的时候给位置挪动一下位置，也就是原始保存数据的位置没要预留空间
            //快速的增删改查，空间换时间
            //个性特点：线程安全的

            foreach (DictionaryEntry objDE in table)
            {
                Console.WriteLine(objDE.Key.ToString());
                Console.WriteLine(objDE.Value.ToString());
            }
        }
    }
}
