using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack_Demo
    {
        public void Init()
        {
            //栈,先进后出，后进先出  内存分配上
            {
                Console.WriteLine("******************Queue<T>*****************");
                Stack<string> stringStack = new Stack<string>();
                stringStack.Push("abc");
                stringStack.Push("def");

                foreach (string sS in stringStack)
                {
                    Console.WriteLine(sS);
                }
                Console.WriteLine("Pop Stack's top item ：" + stringStack.Pop());//出栈并删除
                Console.WriteLine("Peek top item from Stack ：" + stringStack.Peek());//获取栈顶元素

                Queue<string> stackCopy = new Queue<string>(stringStack.ToArray());
                foreach (var sC in stackCopy)
                {
                    Console.WriteLine(sC);
                }
                Console.WriteLine("stackCopy Contains 'abc'= " + stackCopy.Contains("abc"));//是否包含
                stackCopy.Clear();//清空栈
                Console.WriteLine("stackCopy's Count =  " + stackCopy.Count());//栈长度
            }
        }

        public void show()
        {

        }
    }
}
