using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] nums = new int[] { 2, 6, 21, 652, 65, 6, 1, 12 };
                Array.Sort(nums);
                foreach (var n in nums)
                {
                    Console.Write("{0}\t", n);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
