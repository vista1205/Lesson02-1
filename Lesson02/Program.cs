using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void dec_to_bin(int n)
        {
            if (n >= 2)
                dec_to_bin(n / 2);
            Console.Write(n % 2);
        }
        static int pow(int a, int b)
        {
            if (b == 1)
                return (a);
            return (a * pow(a, --b));
        }
        static void powst(int a, int b)
        {
            int c = a;
            for (int i = 1; i < b; i++)
                c = c * a;
            Console.WriteLine(c);
        }
        static int pow2(int a, int b)
        {
            if (b == 0)
                return 1;
            int tmp = pow2(a, b / 2);
            if (b % 2 == 0)
                return tmp * tmp;
            else
                return tmp * tmp * a;
        }
        static int kalk(int a, int b, int c)
        {
            if (a > b)
                return 0;
            if (a == b) 
            {
                if (c == 7)
                    return 1;
                else
                    return 0;
            }
            c++;
            return kalk(a + 1, b, c) + kalk(a * 2, b, c);
        }
        static void Main(string[] args)
        {
            dec_to_bin(10);
            Console.WriteLine("\n" + pow(2, 10));
            powst(2, 10);
            Console.WriteLine(pow2(2, 10));
            Console.WriteLine(kalk(3, 20, 0));
            Console.ReadKey();
        }
    }
}
