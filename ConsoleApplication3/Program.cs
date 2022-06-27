using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num = num10;
            string num2 = "";

            if (num10 != 0)
            {
                while (num10 != 0)
                {
                    num2 += num10 % 2;
                    num10 /= 2;
                }
            }
            else
            {
                num2 = "0";
            }


            Console.WriteLine("2: " + num2 + "\t10: " + Convert.ToInt32(num2, 2));
            Console.WriteLine("2: " + To2(num) + "\t10: " + Convert.ToInt32(To2(num), 2));
            Console.ReadKey();
        }
        static string To2(int num)
        {
            if (num > 0)
                return num % 2 + To2(num / 2);
            return "";
        }
    }
}
