using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Queue_Demo
    {
        public void show()
        {
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
                Console.WriteLine("Dequeuing ：" + stringQueue.Dequeue());//出队列，返回对首的值并移除
                Console.WriteLine("Peek first item from Queue ：" + stringQueue.Peek());//获取队首元素,但是不移除
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
        }
    }
}
