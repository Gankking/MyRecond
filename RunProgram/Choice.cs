using Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunProgram
{
    public static class Choice
    {
        public static void RunItem(int code)
        {
            try {
                switch (code) {
                    case 751:
                        startInfo("LSD 基数排序");
                        int[] a = { 1, 5, 2, 3, 4, 9, 8 };
                        _7_5_1_RadixSort_LSD radixSort = new _7_5_1_RadixSort_LSD();
                        radixSort.RadixSort(a, a.Length);
                        endInfo("LSD 基数排序");
                        break;
                    default:
                        Console.WriteLine("对应编号的程序不存在！");
                        break;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public static void startInfo(string programName){
            Console.WriteLine("**************************************" + programName + "**Start");
        }
        public static void endInfo(string programName)
        {
            Console.WriteLine("**************************************" + programName + "**End");
        }
    }
}
