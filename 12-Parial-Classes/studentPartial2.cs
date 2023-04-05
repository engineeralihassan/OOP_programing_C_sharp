using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _12_Parial_Classes
{
   public partial class studentPartial
    {
        public void getCompleteName()
        {
            Console.WriteLine("The full name is :  {0} {1}", this._firstName, this._lastName);
        }
    }
}
