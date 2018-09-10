using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache缓存
{
    /// <summary>
    /// 远程接口
    /// </summary>
    public class RemoteHepler
    {
        public static List<T> Query<T>()
        {
            Console.WriteLine("This is {0} Query.", typeof(RemoteHepler));
            long lResult = 0;
            for (int i = 0; i < 10000000; i++)
            {
                lResult += i;
            }
            return new List<T>()
            {
                default(T),default(T),default(T),default(T)
            };
        }
    }
}
