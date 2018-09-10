using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache缓存
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //不用缓存，硬来
            try {
                //静态的东西是不会回收的
                Console.WriteLine("******************************************************");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"获取{nameof(DBHelper)}{i}次数  {DateTime.Now.ToString("yyyyMMdd HHmmss.fff")}");
                    List<Program> programList = DBHelper.Query<Program>();
                }
                Console.WriteLine("******************************************************");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"获取{nameof(FileHelper)}{i}次数  {DateTime.Now.ToString("yyyyMMdd HHmmss.fff")}");
                    List<Program> programList = FileHelper.Query<Program>();
                }
                Console.WriteLine("******************************************************");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"获取{nameof(RemoteHepler)}{i}次数  {DateTime.Now.ToString("yyyyMMdd HHmmss.fff")}");
                    List<Program> programList = RemoteHepler.Query<Program>();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
