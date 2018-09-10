using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA.Web.Test
{
    /// <summary>
    /// 1.SOA的思想  分布式思想
    /// 2.建立webserivce 测试服务调用
    /// 3.WCF多宿主多协议等
    /// 
    /// SOA面向服务框架
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("学习SOA和WebService、WCF");
                testWS();
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }



        public static void testWS()
        {
            //MyWebServiceSoapClient是一个代理模式，里面封装了很多东西
            using (WebServiceTest.MyWebServiceSoapClient client = new
                WebServiceTest.MyWebServiceSoapClient())
            {
                //在这里设置断点的话，运行到这里，会进入托管服务上面的地方
                //HelloWorld()这些在添加服务引用的时候，都会自动根据asmx文件里面的方法自动封装好
                string result = client.HelloWorld();

                //因为序列化的原因，将获取的集合改为array；可以右键引用的服务"配置服务引用"，将集合配置改为“list”
                var list = client.UserList();

                Console.WriteLine(result);
                foreach (var user in list) {
                    Console.WriteLine(user.Name+" "+user.Age+" "+user.Sex);
                }
            }
        }
    }
}
