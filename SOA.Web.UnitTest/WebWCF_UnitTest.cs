using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOA.Web.UnitTest
{
    [TestClass]
    public class WebWCF_UnitTest
    {
        [TestMethod]
        public void TestWebWCF_UnitTest()
        {
            //WCF使用try catch，而WebService使用using
            WebWCF_test.WebWCFClient client = null;
            try {
                client = new WebWCF_test.WebWCFClient();
                var stringResult = client.DoWork();
                var intResult = client.Minus(32,33);
                //client.Puls;因为在IWebWCF.cs中Puls方法没有使用[OperationContract]特性
                client.Close();

                Console.WriteLine(stringResult+" "+ intResult);

            }
            catch (Exception ex) {
                if (client != null) {
                    client.Abort();//当网络出现问题的时候，不能正常关闭
                }
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }
    }
}
