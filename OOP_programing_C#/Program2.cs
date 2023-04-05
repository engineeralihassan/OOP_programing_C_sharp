using System.Runtime.CompilerServices;

namespace OOP_programing_C_
{
    /*
     * 
     class Program
    {
        // classes has 2 things 
        //properties | methods called behaviors
        // Properties 
        int rollno;
        string name;
        int age;
        int standard;

        // constructors in c# 
        public void setall(string name,int age,int standard,int roll)
        {
            this.name = name;
            this.age = age;
            this.standard =standard ;
            this.rollno = roll;

        }
        public void getall()
        {
            Console.WriteLine("Your name is: {0}",this.name);
            Console.WriteLine("Your age is: {0}", this.age);

            Console.WriteLine("Your class is: {0}", this.rollno);

            Console.WriteLine("Your rollNo is: {0}", this.standard);
        }


        static void Main(string[] args)
        {
      
            
            Console.WriteLine("Inshallah i became " +
                "a programing master");
            // make object 
            Program ali = new Program();
            
            ali.setall(name:"Ali hassan",age:20,roll:5063,standard:11);
            ali.getall();
            // second object
            Program ali1 = new Program();

            ali1.setall(name: "Danish Riaz", age: 23, roll: 5061, standard: 12);
            ali1.getall();

        }
    }*/

    // ///////////////////////////////////////////
    // C#   constructors
    /*
        class Program
        {
            // classes has 2 things 
            //properties | methods called behaviors
            // Properties 
            int rollno;
            string name;
            int age;
            int standard;

            // constructors in c# 
            // constructor creation 
            Program(string name, int age, int standard, int roll)
            {
                this.name = name;
                this.age = age;
                this.standard = standard;
                this.rollno = roll;
                Console.WriteLine("Constructor is called automatically");
            }
            // Constructor Overloading
            // when we have one or  ore constructors in a class
            Program(int a,int b)
            {
                Console.WriteLine("The sum of {0} and {1} is :",a,b,a+b);
            }
            Program()
            {
                Console.WriteLine("This is defulat constructor" );

            }
            // change  type of parameters
            Program(string b, int a)
            {
                Console.WriteLine("The sum of {0} and {1} is :", a, b, a + b);
            }

            public void getall()
            {
                Console.WriteLine("Your name is: {0}", this.name);
                Console.WriteLine("Your age is: {0}", this.age);

                Console.WriteLine("Your class is: {0}", this.rollno);

                Console.WriteLine("Your rollNo is: {0}", this.standard);
            }


            static void Main(string[] args)
            {


                Console.WriteLine("Inshallah i became " +
                    "a programing master");
                // make object 
                Program ali = new Program(name: "Ali hassan", age: 20, roll: 5063, standard: 11);


                ali.getall();
                // second object
                Program danish = new Program();  // run defualt constructor

                Program ahsan = new Program(12,45);
                Program adeel = new Program("Adeel",23);



            }
            */

    ///////////////////////////////////////////////////
    // Static and instance methods variables || constructors || Copy constructor
    /*
     class Student
     {
       public  int name;
        public double reg_No;
       public  double cgpa;
         public int age = 23;
         // static variable 
         public static int number;
         public static int number1;

         public static string school = "London school of bussiness";
        public Student(double reg, int age )
         {
             this.age = age;
             this.reg_No = reg
 ;        }        
        // static Student()
        // {
            // number = 12;
            // number1 = 234567;
            // Console.WriteLine("The static constructor is called");

         //}
         // copy constructor
         public Student(Student ali)
         {
             this.reg_No = ali.cgpa;
             this.age = ali.age;

         }

         // instance methods
         public void printAge()
         {
             Console.WriteLine("You age is {0}", age);
         }
         // static methods
         public static int num()
         {
             // we can only used the static variables in c# static methods
             Console.WriteLine("your school is :{0}",Student.school);
             return 23456;
         }
     }
     class Program
     {
         // instance variables
         int rollno;
         string name;
          int age=123;
         int standard;

          //instance  methods










         static void Main(string[] args)
         {


             Console.WriteLine("Inshallah i became " +
                 "a programing master");
             // make object 
             Student ali = new Student(23.4,25);
             ali.cgpa = 1222.34;
             Console.WriteLine(ali.cgpa);
             // second obj
             Student danish = new Student(ali);
             // call the instrance method by objectname

             danish.printAge();

             // static variable is same for all object
             // we create form class

             Console.WriteLine(Student.school) ;
             string school = Student.school;
             Console.WriteLine(school);
             school =Student.school = "Alhamra center";
             Console.WriteLine(school);
             Console.WriteLine(Student.school);
             // static methods
             int num = Student.num();
             Console.WriteLine(num);

             // make new obj and used the previouse obj values through copy constructor

             Student obj = new Student(ali);
             Console.WriteLine("New age is"+obj.age);






         }




     }


     */

    ///////////////////////////////////////////
    /////    Static class in c#
    ///  no object no inherited
    // only static memebers 

    /*
        static class Friend
        {
            public static int age;
            public static int age1;
            public static int age3;
            public static int age2;
            static Friend()
            {
            age= 123;
                age2 = 345;
                age3 = 45678;
                age1 = 4567890;


            }
            public static void getAges()
            {
                Console.WriteLine("The age 1 is : {0}",age);
                Console.WriteLine("The age 1 is : {0}", age1);
                Console.WriteLine("The age 1 is : {0}", age2);
                Console.WriteLine("The age 1 is : {0}", age3);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("runing successfully");

                // call the methods of static class
                Friend.getAges();
            }



        }
    }


        */


    ///////////////////////////////////////////
    ///  # Destructures in c# 
    ///  // same class name memory dealocations | not overloaded | not inherited | no parameters
    ///  no 
    ///  
    /*
    public class MyClass
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        ~MyClass()
        {
            Console.WriteLine("Memory cleared.");
        }
    }

    public class Friend
    {
        public  int age;
        public  int salry;

         public Friend(int age, int salary)
        {
            this.age=age;
            this.salry = salary;
            


        }

        public void get()
        {
            Console.WriteLine("Your age is: {0}",this.age);
            Console.WriteLine("Your salary is : ",this.salry);


        }
        ~Friend()
        {
            Console.WriteLine("contruct running all meory is free now");
        }


      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("runing successfully");

            // call the methods of static class
            Friend pi = new Friend(23,2500);
            pi.get();

            MyClass myObj = new MyClass();
            myObj.Value = 10;
        }



    }
}
    */
    // ///////////////////////////////////////////////////////////////////////////////
    //  # Inheritance in c#
    /*
    public class Employs
    {
        public int EmplId;
        public string EmpName;

        public int EmpAge;
        public int EmpContact;

        public void show()
        {
            Console.WriteLine("This is method of employs class");

        }

    }
    public class Visiting_Employs : Employs
    {
        public int visitingSalry;
        public int workHourse;

    }
    public class Permanent_Employs: Employs
    {
        public int perSalry;
        public int workHourse;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inhritance is start Ali You Win Inshallah");
            // Making object of the Permanent Emloyees
            Permanent_Employs ali = new Permanent_Employs();
            ali.EmplId = 12;
            ali.workHourse = 9;
            Console.WriteLine(ali.EmplId) ;
            Visiting_Employs asim = new Visiting_Employs();
            asim.EmplId = 45;
            asim.workHourse = 10;
            Console.WriteLine(asim.EmplId);
            asim.show(); 


        }



    }
    */
    ////////////////////////////////////////////
    // Types of Inheritance
    // 4 types of inheritance in  c#
    // Single | heirarical | multi level | Multiple
    // single inheritance
    /*
    public class Employs
    {
        public int EmplId;
        public string EmpName;

        public int EmpAge;
        public int EmpContact;

        public void show()
        {
            Console.WriteLine("This is method of employs class");

        }

    }
    public class Visiting_Employs : Employs
    {
        public int visitingSalry;
        public int workHourse;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inhritance is start Ali You Win Inshallah");
            // Making object of the Permanent Emloyees
           
          
            Visiting_Employs asim = new Visiting_Employs();
            asim.EmplId = 45;
            asim.workHourse = 10;
            Console.WriteLine(asim.EmplId);
            asim.show();


        }



    }
    */

    /////////////////////////////////////
    /// Heirarical Inheritance
    /*
     public class Employs
   {
       public int EmplId;
   public string EmpName;

   public int EmpAge;
   public int EmpContact;

   public void show()
   {
       Console.WriteLine("This is method of employs class");

   }

}
   public class Permanent_Employs : Employs
   {
       public int Salry;
       public int workHourse;

   }
   public class Visiting_Employs : Employs
{
   public int visitingSalry;
   public int workHourse;

}
   public class M2_Employs : Employs
   {
       public int Salry;
       public int workHourse;

   }

   class Program
{
   static void Main(string[] args)
   {
       Console.WriteLine("Inhritance is start Ali You Win Inshallah");
       // Making object of the Permanent Emloyees


       Visiting_Employs asim = new Visiting_Employs();
       asim.EmplId = 45;
       asim.workHourse = 10;
       Console.WriteLine(asim.EmplId);
       asim.show();


   }



}
   */
    /////////////////////////////////////////////
    /// Multilevel inheritance
    /*
        public class Employs
        {
            public int EmplId;
            public string EmpName;

            public int EmpAge;
            public int EmpContact;
            public int s1;

            public void show()
            {
                Console.WriteLine("This is method of employs class");

            }

        }
        public class Permanent_Employs : Employs
        {
            public int Salry;
            public int workHourse;
            public int s3;

        }
        public class Visiting_Employs : Permanent_Employs
        {
            public int visitingSalry;
            public int workHourse;

        }
        public class M2_Employs : Visiting_Employs    {
            public int Salry;
            public int workHourse;


        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Inhritance is start Ali You Win Inshallah");
                // Making object of the Permanent Emloyees


                Visiting_Employs asim = new Visiting_Employs();
                asim.EmplId = 45;
                asim.workHourse = 10;
                Console.WriteLine(asim.EmplId);
                asim.show();
                Secondclass m34 = new Secondclass();
                M2_Employs m1 = new M2_Employs();
                m1.s3 = 1234;
                Console.WriteLine(m1.s3);
                m34.secondClassVar = "Yes Ali its posible";
                Console.WriteLine(m34.secondClassVar);

            }



        }
        */
    /////
   //  Multiple inheritance using interfaces  

    class person
    {
        public void show()
        {
            Console.WriteLine("This is the person classs methods");
        }
    }
    interface Teacher
    {
        void show();
    }
    class student : person , Teacher  // this is error ic case of two base class
 {
         void Teacher.show()
        {

            Console.WriteLine("This is the explanation of interface methods");
        }


    }

    class Program2
    {
        static void Main(string[] args)
        {
            
          

            Console.WriteLine("Ali Never giv up one day success is knock on your door");
            student n = new student();
           
            n.show();
            Teacher e = new student();
            e.show();



        }



    }


    ///////////////////////////////////////////////
    ///// consttructors in inheritance
    ///
    /*
      class Baseclass
      {
          public Baseclass(string mesg)
          {
              Console.WriteLine("This is constructor of Base Class {0}",mesg);
          }

      }
      class Deiveclass: Baseclass
      {
  public Deiveclass() :base("Hello Ali How are You")
          {
              Console.WriteLine("This is constructor of Derive class");
          }
      }
      class Program
      {
          static void Main(string[] args)
          {
              //consructors in Inheritancey
              Deiveclass m1 = new Deiveclass();




          }



      }
      */

    ///////////////////////////////////////////////
    ///// Access Specifiers
    // public private protected internal specifiers
    // Public =  acceess every where in the project
    // private = bydefualt = not access outside the class
    //
    /*
    class ParentClass
    {
        public int publicVar = 1;
        protected int protectedVar = 2;
    }

    class DerivedClass : ParentClass
    {
        public int Age { get; set; }
        public int PublicVar { get; set; }
        public int ProtectedVar { get; set; }

        public DerivedClass()
        {
            PublicVar = base.publicVar;
            ProtectedVar = base.protectedVar;
        }
    }

    // Usage



   //
   public class Baseclass
    {
        public int a=345;
        public int b;
        protected int c;
        public void metho()
        {
            Console.WriteLine("This is public method of the base class");
        }
          
        public Baseclass(string mesg)
        {
            Console.WriteLine("This is constructor of Base Class {0}", mesg);
        }
        protected void SomeMethod()
        {
            Console.WriteLine("This is a method of the base class.");
        }

    }
    public class Deiveclass : Baseclass
    {
        public int s;
        public Deiveclass() : base("Hello Ali How are You")
        {
            Console.WriteLine("This is constructor of Derive class");
            s = base.a;//
        }
     

    }
    class Program2
    {
        static void Main(string[] args)
        {
            //consructors in Inheritancey
            Deiveclass m1 = new Deiveclass();

            DerivedClass instance = new DerivedClass();
            instance.Age = 30;

            Console.WriteLine($"Age: {instance.Age}, PublicVar: {instance.PublicVar}, ProtectedVar: {instance.ProtectedVar}");


        }



    }
    */
}