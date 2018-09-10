using System;
//特性，空间
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOA.Web.UnitTest
{
    [TestClass]
    public class WebServiceUnitTest
    {
        //应用服务，托管的服务网站必须开启 http://localhost:62247/Remote/MyWebService.asmx
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("12345");
        }

        [TestInitialize]//有这个先执行这个
        public void Init()
        {
            Console.WriteLine("初始化日志");
        }


        //单独写，或者直接加载到“WebServiceUnitTest.cs”下面是一样的，添加服务应用之类的，在主函数，或者封装起来，度可以
        [TestMethod]
        public void testWS()
        {
            //MyWebServiceSoapClient是一个代理模式，里面封装了很多东西
            using (WebServiceTest.MyWebServiceSoapClient client = new
                WebServiceTest.MyWebServiceSoapClient())
            {
                //在这里设置断点的话，运行到这里，会进入托管服务上面的地方
                //HelloWorld()这些在添加服务引用的时候，都会自动根据asmx文件里面的方法自动封装好
                string result = client.HelloWorld();

                //因为设置了SoupHeader,所以需要验证
                WebServiceTest.CustomSoapHeader soapHeader = new WebServiceTest.CustomSoapHeader()
                {
                    UserName = "陈贺章"
                    //UserName = "Hermes"
                };
                var list = client.UserList(soapHeader);//无论是否正确都会通过，取出数据
                int status = client.Minus(soapHeader,123,12);//如果不匹配返回404状态码，正确的话，返回差值
                Assert.AreEqual("Hello World",result);//断言
            }
        }
    }
}
