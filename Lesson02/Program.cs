using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        #region 1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
        static void dec_to_bin(int n)
        {
            if (n >= 2)
                dec_to_bin(n / 2);
            Console.Write(n % 2);
        }
        #endregion

        #region 2. Реализовать функцию возведения числа a в степень b:
        #region b. рекурсивно;
        static int pow(int a, int b)
        {
            if (b == 1)
                return (a);
            return (a * pow(a, --b));
        }
        #endregion
        #region a. без рекурсии;
        static void powst(int a, int b)
        {
            int c = a;
            for (int i = 1; i < b; i++)
                c = c * a;
            Console.WriteLine(c);
        }
        #endregion
        #region c. *рекурсивно, используя свойство четности степени.
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
        #endregion
        #endregion
        #region 3. Исполнитель Калькулятор преобразует целое число, записанное на экране.
        #region б) с использованием рекурсии.
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
        #endregion
        #endregion
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
