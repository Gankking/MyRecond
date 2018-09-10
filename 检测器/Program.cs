using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 排序;

namespace 检测器
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 对数器的使用
            /// 修改要被测试的方法：F12,进入RightSort类
            /// </summary>
            /// <param name="args">【1,m】位数，数值=【1,n】</param>
            RightSort rs = new RightSort();
            rs.Init(5,10);

            //运行时间检测
        }
    }
}
