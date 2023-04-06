using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Extensions_Methods
{
     class TestExtensionsMethods
    {

        static void Main()
        {
            Program p = new Program();
            p.Func3(4);
            int i = 20;
            bool result = i.IsGreaterthen(10);
            Console.WriteLine(result);
            p.Func2();


        }
    }
}
