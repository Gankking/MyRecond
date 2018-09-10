using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOA.Web.UnitTest
{
    [TestClass]
    public class ConsoleWCFTcp_UnitTest
    {
        [TestMethod]
        public void TestConsoleWCFTcp_Test()
        {
            //WCF使用try catch，而WebService使用using
            ConsoleWCFTcp_Test.MathServiceClient client = null;
            try
            {
                client = new ConsoleWCFTcp_Test.MathServiceClient();
                var stringResult = client.UserList();
                var user = client.GetUser(1,2);
                var intResult = client.PlusInt(32, 33);
                //client.Puls;因为在IWebWCF.cs中Puls方法没有使用[OperationContract]特性
                client.Close();

                Console.WriteLine(stringResult + " " + intResult);

            }
            catch (Exception ex)
            {
                if (client != null)
                {
                    client.Abort();//当网络出现问题的时候，不能正常关闭
                }
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
