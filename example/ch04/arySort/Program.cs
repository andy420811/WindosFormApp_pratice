using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myKeys = new int[] { 90, 60, 50, 70, 80 };
            string[] myValues = new string[] { "mary", "jack", "tom", "david", "grace" };

            Console.WriteLine(" Before sort: ");
            Console.WriteLine(" Subscript  Relative value   Index key ");
            for (int k = 0; k <= myKeys.Length - 1; k++)
                Console.Write(" k={0} \t{1} :\t {2} \n", k, myValues[k], myKeys[k]);
            Console.WriteLine();

            Array.Sort(myKeys, myValues);
            Console.WriteLine(" After sort: ");
            Console.WriteLine(" Subscript  Relative value   Index key ");
            for (int k = 0; k <= myKeys.Length - 1; k++)
                Console.Write(" k={0} \t{1} :\t  {2} \n", k, myValues[k], myKeys[k]);
            Console.Read();
        }
    }
}
