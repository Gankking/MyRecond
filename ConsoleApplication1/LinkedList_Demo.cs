using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LinkedList_Demo
    {
        public void show() {
            //LinkedList 链表,随机动态分配内存，不连续内存；添加和删除效率高，查询慢
            {
                Console.WriteLine("******************LinkedList<T>*****************");
                LinkedList<int> linkedList = new LinkedList<int>();
                linkedList.AddFirst(123);
                linkedList.AddLast(456);
                //linkedList[];  不能用索引

                bool isContain = linkedList.Contains(123);
                LinkedListNode<int> node123 = linkedList.Find(123);//元素123的位置，从头查询
                linkedList.AddBefore(node123, 0);
                linkedList.AddBefore(node123, 9);

                linkedList.Remove(456);
                linkedList.Remove(node123);
                linkedList.RemoveFirst();
                linkedList.RemoveLast();
                linkedList.Clear();
            }
        }
    }
}
