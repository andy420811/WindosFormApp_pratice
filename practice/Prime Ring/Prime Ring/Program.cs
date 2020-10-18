using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Ring
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] num_arr = new int[50];
            int[] check = new int[50];
            int num;
            num = Int32.Parse(Console.ReadLine());
            if(num < 2 || num > 16||num%2==1)
            {
                Console.WriteLine("Input an even integer (2 <= n <= 16)");
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    num_arr[i] = i;
                }
                Primring(2,ref check,ref num_arr, num);

            }


            Console.ReadKey();
        }
        public static bool isPrim(int n)
        {
            if (n < 4)
                return true;
            if (n % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void Primring(int process,ref int[] check,ref int[] num_arr,int num)
        {
            int i;
            if (process == num + 1 && isPrim(num_arr[num] + num_arr[1]))
            {
                for (i = 1; i < num; i++)
                    Console.Write(num_arr[i]);
                Console.WriteLine(num_arr[num]);
            }
            for (i = 2; i <= num; i++)
            {
                if ((check[i] == 0 )&& isPrim(i + num_arr[process - 1]))
                {
                    num_arr[process] = i;
                    check[i] = 1;
                    Primring(process + 1,ref check,ref num_arr,num);
                    check[i] = 0;
                }
            }
        }


    }
}
