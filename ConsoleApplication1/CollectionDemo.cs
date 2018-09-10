using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CollectionDemo
    {
        public static void show()
        {
            //数组,不能扩展，分配在连续内存的;性能高，索性查找快，数据再多也没有影响；插入很慢，需要移动之后的数
            {
                Console.WriteLine("******************Array*****************");
                int[] intArray = new int[3];
                intArray[0] = 123;
                intArray[1] = 456;
                intArray[1] = 789;

                string[] stringArray = new string[] { "123", "456", "789" };
            }
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
            //LinkedList 链表,随机动态分配内存，不连续内存；添加和删除效率高，查询慢
            {
                Console.WriteLine("******************LinkedList<T>*****************");
                LinkedList<int> linkedList = new LinkedList<int>();
                linkedList.AddFirst(123);
                linkedList.AddLast(456);
                //linkedList[];  不能用索引

                bool isContain = linkedList.Contains(123);
                LinkedListNode<int> node123 = linkedList.Find(123);//元素123的位置，从头查询
                linkedList.AddBefore(node123,0);
                linkedList.AddBefore(node123, 9);

                linkedList.Remove(456);
                linkedList.Remove(node123);
                linkedList.RemoveFirst();
                linkedList.RemoveLast();
                linkedList.Clear();
            }
            //队列，先进先出  多线程写日志，把日志写入Queue，弄个线程专门使用，来写日志
            {
                Console.WriteLine("******************Queue<T>*****************");
                Queue<string> stringQueue = new Queue<string>();
                stringQueue.Enqueue("One");//进队列
                stringQueue.Enqueue("Two");
                stringQueue.Enqueue("Three");
                stringQueue.Enqueue("Four");
                stringQueue.Enqueue("Five");
                foreach (string s in stringQueue)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Dequeuing ："+ stringQueue.Dequeue());//出队列
                Console.WriteLine("Peek first item from Queue ：" + stringQueue.Peek());//获取队首元素
                Console.WriteLine("Dequeuing ：" + stringQueue.Dequeue());//
                Console.WriteLine("Dequeuing ：" + stringQueue.Dequeue());//

                Queue<string> queueCopy = new Queue<string>(stringQueue.ToArray());
                foreach (var qC in queueCopy)
                {
                    Console.WriteLine(qC);
                }
                Console.WriteLine("queueCopy Contains 'Three'= " + queueCopy.Contains("Three"));//是否包含
                queueCopy.Clear();//清空队列
                Console.WriteLine("queueCopy's Count =  " + queueCopy.Count());//队列长度
            }
            //栈
            {
                Console.WriteLine("******************Queue<T>*****************");
            }
        }
    }
}
