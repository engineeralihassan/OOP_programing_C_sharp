using System.Text.Json;

namespace _08_Generics
{
    /// Generics are used to make functions class which accept all kinds of data
    /*class Example
       {
         public static void show<T>( T[] arr)
           {
               for(int i=0; i<arr.Length; i++)
               {
                   Console.WriteLine(arr[i]);
               }
           }
           // overloading avoide by generics
           public static bool calculate<T>( T a, T b)
           {
               bool c = a.Equals(b);
               return c;
           }

       }



       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("All About Generics");
               int[] nums = { 12, 34, 56, 78, 90 };
               dynamic[] diff = { "Ali", 12, "Amjad Sabri", "Aslam", 12.56 }
               ;
               Example.show(nums);
               string[] names = {  "Ali ","Hassan","Mahindra","Sachil","Grabing","Sundarta" };


               Example.show(names);
               Example.show(diff);
               Console.WriteLine(Example.calculate("Ali", "Ahsan"));
               Console.WriteLine(Example.calculate(10,10));

           }
       }*/
    ///////////////////////////////////////
    // Generics in classes

    /// Generics are used to make functions class which accept
    /// all kinds of data
    /* class Example<T>
     {
         T box;
         T age;

         public  Example(T a)
         {
             this.box = a;
         }
         public T getBox()
         {
             return this.box;
         }
         // Generics properties
         public T Age
         {
             set
             {
                 this.age = value;

             }
             get
             {
                 return this.age ;

             }



         }

     }



     class Program
     {
         static void Main(string[] args)
         {
             Example<int> e = new Example<int>(20);
             Console.WriteLine(e.getBox());
             Example<string> e1 = new Example<string>("Ali Hassan");
             Console.WriteLine(e1.getBox());
             e.Age = 21;
             Console.WriteLine(e.Age);

         }
     }
     */
    ///////////////////////////////////////////////////////
    // Collections in c#
    // Generics and non Generics

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections in C#");
            int[] arr = new int[4];
            arr[1] = 17;
            arr[2] = 11;
            arr[3] = 14;
            arr[0] = 189;
            Array.Resize(ref arr, 8);
            arr[6] = 112;
            arr[5] = 124;
            arr[4] = 1289;
            Console.WriteLine(arr[6]);

        }
    }
}