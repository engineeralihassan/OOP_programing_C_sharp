namespace Polimorphism
{
    // static polymorphism
    // operator overloading | method overloading
    // many functions with same names

    /*
    class Person
    {
        public string str;
        public int num;

        // method for operator overloading
        public static Person operator + (Person obj1,Person obj2)
        {
            Person obj3 = new Person();
            obj3.str = obj1.str +" "+ obj2.str;
            obj3.num = obj1.num  + obj2.num;
            return obj3;

        }

    }
    //
    class MyClass
    {
        public int value;

        public MyClass(int val)
        {
            value = val;
        }

        // Overload the + operator
        public static MyClass operator +(MyClass obj1, MyClass obj2)
        {
            int sum = obj1.value + obj2.value;
            return new MyClass(sum);
        }
    }
    class Program4
    {
        //functions overloading
       /* public void add()
        {
            int a = 20;
            int b = 34;
            int c = a + b;
            Console.WriteLine("The sum is:{0}", c);

        }*/
    //public void add(int a)
    //{

    //    int b = 34;
    //    int c = a + b;
    //    Console.WriteLine("The sum is:{0}", c);

    //}
    //public void add(string a)
    //{


    //    string  c = a;
    //    Console.WriteLine("The sum is:{0}", c);

    //}

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("All about Polimorphism");
    /*
    Program4 pi = new Program4();
    pi.add();
    pi.add(12);
    pi.add("Ali Hassan");
    */
    // operator overloading
    /*
    Person obj1 = new Person();
    obj1.str = "Ali";
    obj1.num = 23;
    Person obj2 = new Person();
    obj2.str = "hassan";
    obj2.num = 25;
    Person obj3 = obj1 + obj2;

    Console.WriteLine(obj3.str+ obj3.num);
    //MyClass obj1 = new MyClass(10);
    //MyClass obj2 = new MyClass(20);
    //MyClass obj3 = obj1 + obj2;

    //Console.WriteLine("obj3.value = {0}", obj3.value);



}
}
*/
    // //////////////////////////////////////////////////////////////
    // Method Hiding
    /*  class MyClass
 {
    public void show()
     {
         Console.WriteLine("this is parent class method");
     }
 }
 class MyClass1: MyClass
 {
     public new void show()
     {
         //base.show();
         Console.WriteLine("this is child class method");
     }
 }

 class Program4
 {
     static void Main(string[] args)
     {
         // MyClass1 obj1 = new MyClass1();
         //obj1.show();
         MyClass p = new MyClass1();// run parent method

         //((MyClass)obj1).show();
         p.show();

         // Output: obj3.value = 30
     }
 }*/

    /////////////////////////////////////////
    /// Another example of method hiding
    /* class Employ
     {
         public void show()
         {
             Console.WriteLine("this is Employ class method");
         }
     }
     class PartTimeEmploy : Employ
     {
         public new void show()
         {
             // if we want to call parent class method
             base.show();
            // Console.WriteLine("this is PartTimeEmploy class method");
         }
     }
     class FullTimeEmploy : Employ
     {
         public new void show()
         {
             Console.WriteLine("this is FullTimeEmploy class method");
         }
     }


     class Program4
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Ali try try again one day you will became a good ");
             PartTimeEmploy PTE = new PartTimeEmploy();
             PTE.show();

         }
     }*/
    /////////////////////////////////////////////////////////
    /// Methor overriding
    /*
   class Employ
   {
       public  virtual void show()
       {
           Console.WriteLine("this is Employ class method");
       }
   }
   //class PartTimeEmploy : Employ
   //{
   //    public  void show()
   //    {
   //        // if we want to call parent class method
   //        base.show();
   //        // Console.WriteLine("this is PartTimeEmploy class method");
   //    }
   //}
   class FullTimeEmploy : Employ
   {
       public override  void show()
       {
           Console.WriteLine("this is FullTimeEmploy class method");
       }
   }


   class Program4
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Ali try try again one day you will became a good ");
          Employ p = new FullTimeEmploy();

           p.show();

       } 
   }*/
    ///////////////////////////////////////////////////////////
    /// Sealed Class in c#
    /// prevent inheritance | no child classes
    /// // Sealed methods
    /*
    class Employ
    {
        public virtual void show()
        {
            Console.WriteLine("this is Employ class method");
        }
    }
  
    class FullTimeEmploy : Employ
    {
        public override void show()
        {
            Console.WriteLine("this is FullTimeEmploy class method");
        } 
    }
    class PartEmploy : FullTimeEmploy
    {
        public sealed override void show() // then method is never ovverrde again
        {
            Console.WriteLine("this is PartTimeEmploy class method");
        }
    }


    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All about Sealed class in C#");
            PartEmploy p = new PartEmploy();
            p.show();

        }
    }
*/
    /////////////////////////////////////////////////
    ///  Indexers in c3
    ///  

    class Employ
    {
     private   int[] Ages = new int[4];
        public int a = 12;
         public int  this[int index]
        {
            set
            {
                if (index >= 0 && index < Ages.Length) { 
                     if (value > 0)
                     {
                    Ages[index] = value;

                     }
                     else
                      {
                    Console.WriteLine("Please enter positive value");

                     }

                }
                else
                {
                    Console.WriteLine("Invalid Index !!");
                }
            
            }
            get { /* return the specified index here */

                return Ages[index];
            }
           
        }

    }

    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All about indexers in C#");

            Employ p = new Employ();
            p[0] = 3;
            Console.WriteLine(p[0]);
            p[1] = -3;
            p[4] = 5;
            Console.WriteLine(p.a);

        }
    }



}