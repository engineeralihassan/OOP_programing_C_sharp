using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Extensions_Methods
{
 
    static class My_staticClass
    {
        public static void Func3(this Program p,int i)
        {
            Console.WriteLine("This is function  3");

        }
        public static bool IsGreaterthen(this int i, int value)
        {
            return i > value;

        }

        public static void Func2(this Program p)
        {
            Console.WriteLine("This is second function");

        }









    }
}
