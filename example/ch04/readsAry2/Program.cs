using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readsAry2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "AA", "BB", "CC", "DD", "EE" };
            int[,] score = { { 80, 75, 60 }, { 65, 67, 62 }, { 100, 93, 91 }, { 98, 25, 50 }, { 83, 82, 87 } };
            int no;
            Console.Write(" Input seat number (1-5) : ");
            no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
            {
                Console.WriteLine("1. Student name : {0} ", name[no - 1]);
                Console.WriteLine("2. Chinese : {0} ", score[no - 1, 0]);
                Console.WriteLine("3. English : {0} ", score[no - 1, 1]);
                Console.WriteLine("4. Mathematics : {0} ", score[no - 1, 2]);
            }
            else
                Console.WriteLine(" ... This is an empty number ... ");
            Console.Read();
        }
    }
}
