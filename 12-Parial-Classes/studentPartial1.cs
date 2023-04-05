using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Parial_Classes
{
    public partial class studentPartial
    {
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            set
            {
                this._firstName = value;

            }
            get
            {
                return this._firstName;
            }
        }
        public string lastName
        {
            set
            {
                this._lastName = value;

            }
            get
            {
                return this._lastName;
            }
        }
      
    }
}
