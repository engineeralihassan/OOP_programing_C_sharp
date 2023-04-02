using System.Runtime.CompilerServices;

namespace Encapsulation
{

    // wrape data | set data | get data

    /*
    class Person
    {
        // Encapsolation
        //make all them private
       private  string name;
        private int age;
        // methods to set data
        public void setData(string name, int age)
        {
            if (string.IsNullOrEmpty(name) && age>0)
            {
                Console.WriteLine("The name is required age must be positive");

            }
            else
            {
                this.name = name;
                this.age = age;

            }
         // we make methds reads only and write only


        }
        public void getData()
        {
            Console.WriteLine("You name is : {0}", this.name);
            Console.WriteLine("your age is {0}",this.age);


        }
    }




     class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All About the Encapsolations");
            // make object
            Person p1 = new Person();
            // p1.name = "Ali Hassan";
            // p1.age = 12;// not eccapsolation
            p1.setData("Ali Hassan", 21);
            p1.getData();
        }
    }*/

    ///////////////////////////////////////////////
    ///  # Properties with get and set
    class Person
    {
        // Properties 
        // set and get  
        private string _name;
        private int _age;
        private string gender="Male";
        public string lastName { get;  set; }
        public string l1 {  private get;   set; }
        public string l2 { get; private set; }
        // static propert
        private static string uniName;
        private static string depName;

        public static string UniProperty {
            set
            {
                uniName = value;

            }

            get
            {

                return uniName;
            } }
        public static string DepProperty { get; set; }
      
        
        
        public Person()
        {
            l2 = "Amjad Sabri";
           
        }









        public string  Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter something in name");

                }
                else
                {
                    this._name = value;

                }
               
            }
            get
            {
             return  this._name;
            }
        }
      // write only properties
        public int Age
        {
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Enter positive value");

                }
                else
                {
                    this._age = value;

                }

            }
           
        }
        // read only
        public string Gender
        {

            get
            {
                return this.gender;
            }


        }
        //auto implemented


        // we make methds reads only and write only

    }




    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All About the Encapsolations properties");
            // make object
            Person p1 = new Person();
            p1.Name = "Ali Hassan";
            Console.WriteLine(p1.Name);
            p1.Age = 21;
            //  Console.WriteLine(p1.Age);=error
            // p1.Gender = "Male";// read only not set
            Console.WriteLine(p1.Gender);
            p1.lastName = "Hassan";
            Console.WriteLine(p1.lastName);
           
            
            Console.WriteLine(p1.l2);

            // static property
            Person.UniProperty = "University of Okara";
            Console.WriteLine(Person.UniProperty);
        }
    }
}