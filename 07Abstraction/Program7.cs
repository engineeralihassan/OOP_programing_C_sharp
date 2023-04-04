using System.Security.Cryptography.X509Certificates;

namespace _07Abstraction
{
    /*
        class Employ
        {
            public int EmpId;
            public string EmpName;
            public double grosPay;
            public double tex = 0.1;
            double netsalary;

            public Employ(int id, string name, double payl)
            {

                this.EmpId = id;
                this.EmpName = name;
                this.grosPay = payl;


            }

             void calculate()
            {
                if( grosPay>= 30000)
                {
                    netsalary = grosPay-300 ;
                    Console.WriteLine("You salary is {0}",netsalary);

                }
                else
                {

                    Console.WriteLine("You salary is {0}", netsalary);

                }



            }

            public void showDetails()
            {
                this.calculate();

            }






        }
        public class Program7 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Abstractions");
                Employ ali = new Employ(12,"Ali Hassan",45000);
                ali.showDetails();

            }
        }*/
    /////////////////////////////////////////////
    /// Abstract clas and abstract methods
    /// no instance   <summary>
    /// Abstract clas and abstract methods
    /// </summary>
    /* abstract class Person
     {



          public int age;
         public string name;
         public long phone;
         // abstract Properties
       //  public abstract int Id { get; set; }
         public abstract string Name { get; set; }

         public abstract void show_Detals();


     }

     class student: Person
     {
         public int roll;
         public int fees;
         public override  void show_Detals()
         {
             Console.WriteLine("This is the Student class{0}",this.name);
         }
         // overide the abstract clas properties 

         public override string Name {
             set
             {
                 this.name = value;
             }


             get
             {
                 return this.name;
             }



              }

     }
     class teacher:Person
     {
         public string qualification;
         public int salery;
         public override  void show_Detals()
         {
             Console.WriteLine("This is the teacher class{0}",this.name);
         }
         // override the abstract properties
         public override string Name
         {
             set
             {
                 this.name = value;
             }


             get
             {
                 return this.name;
             }



         }

     }






     public class Program7
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Abstractions");
             student ali = new student();
             ali.name = "Ali Hassan";
             ali.age = 21;
             ali.roll = 5063;
             ali.phone = 03133324617;
             ali.show_Detals();

             // teacher class 
             teacher aslam = new teacher();
             aslam.name = "Aslam Shehzad";
             aslam.show_Detals();
             aslam.Name = "Ali Hassan";
             Console.WriteLine(aslam.Name); 





         }
     }*/

    //////////////////////////////////////////
    /// interfaces  
    ///  contract b/t interfaces and class 
    ///  all the properties are abstracted and implemented in child class 
    ///  

    //interfaces inheritance
    /*
           interface Employ

        {


            void show();
        }
        interface  Employ2

        {


            void show1();
        }
        interface Employ3:Employ,Employ2

        {


            void show2();
        }


        class InheritedEmploys : Employ3
        {
            public void show()
            {
                Console.WriteLine("This is the 1  method of Interface");
            }
            public void show1()
            {
                Console.WriteLine("This is the 2  method of Interface");
            }
            public void show2()
            {
                Console.WriteLine("This is the  3 method of Interface");
            }
        }

        public class Program7
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Abstractions");


                // partime employs class
                InheritedEmploys p = new InheritedEmploys();
                p.show();
                p.show1();
                p.show2();
                // we also do that
                Employ3 p1 = new InheritedEmploys();
                p1.show1();








            }



        }*/

    /// Explicit interface types inplementation
    interface Employ
    {
        void show();
    }
    interface Employ2

    {
      void show();
    }
    interface Employ3 
    {
        void show();
    }


    class InheritedEmploys  : Employ3,Employ2,Employ
    {
        void  Employ.show()
        {
            Console.WriteLine("This is the Employ1  method of Interface");
        }
        void Employ2.show()
        {
            Console.WriteLine("This is the Employ2  method of Interface");
        }
        void Employ3.show()
        {
            Console.WriteLine("This is the Employ3  method of Interface");
        }

    }

    public class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstractions");


            // partime employs class
            InheritedEmploys p = new InheritedEmploys();
           ((Employ)p).show();
            ((Employ3)p).show();
            ((Employ2)p).show();








        }



    }


}