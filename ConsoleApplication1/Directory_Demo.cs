using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Directory_Demo
    {
        public void Init()
        {
            Console.WriteLine("******************Directory*****************");
            //泛型的哈希表
            Dictionary<int, string> dic = new Dictionary<int,string>();
            dic.Add(1,"Haha");
            dic.Add(5, "Hehe");
            dic.Add(2, "Hoho");
            dic.Add(4, "Hihi");
            dic.Add(3, "Huhu");

            dic[3] = "Huhu";//覆盖没有问题
            try {
                dic.Add(3, "Huhu");//重复有错
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }

            foreach (var item in dic)
            {
                Console.WriteLine("Key="+item.Key+", Value="+item.Value);
            }
        }
    }
}
