using System.Collections;
using System.Security.Cryptography;

namespace _09_Non_Generics_collections
{
    // arraylist collections
    /*  public class Program
      {
          static void Main(string[] args)
          {
              ArrayList list = new ArrayList();
              list.Add(10);
              list.Add("Ali hassan");
              list.Add("Amjad Sabri");

              list.Add(102);
              list.Add("Ali hassan1");
              list.Add("Amjad Sabri123");

              Console.WriteLine("All About Non-Generics Collection");

              list.Insert(3, "aslam shehzad bhatti");
              // remove 
              list.Remove("Ali hassan");
              foreach (object obj in list)
              {
                  Console.WriteLine(obj + " ");

              }



          }
      } */
    //////////////////////////////////////////////////////
    //  Hash Table collection in c# 
    // store data in key values Pairs

    /*
    public class Program
    {



        static void Main(string[] args)
        {




            Console.WriteLine("All About Non-Generics Collection");
            Hashtable ht = new Hashtable();
            ht.Add("Id", 121);
            ht.Add("phone", 03133324617);
            ht.Add("salery", "25k");
            ht.Add("name", "Ali Hassan");
            ht.Add("IsMarried", false);
            Console.WriteLine(ht["name"]);
            // second methods
            Hashtable ht1 = new Hashtable()
            {
                {12,"chack No" },
                 {"name","Ali Hassan" },
                  {false,"yes its false" },
                   {"roll",5063 },


            };
            Console.WriteLine(ht1[12<5]);
            Console.WriteLine(ht1[14-2]);

            // methods of HashTable
            // ADD | Remove 
            foreach(object key in ht1.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (object key in ht1.Values)
            {
                Console.WriteLine(key);
            }
            foreach (object key in ht1.Keys)
            {
                Console.WriteLine(key + ":  " + ht1[key]);
            }

            // Remove 
            ht1.Remove(12);
            Console.WriteLine("after remove");
            foreach (object key in ht1.Keys)
            {
                Console.WriteLine(key + ":  " + ht1[key]);
            }
            // cleare
            //ht1.Clear(); it clear all the things
            // contians key 
            Console.WriteLine (ht1.Contains("name1"));
            Console.WriteLine(ht1.ContainsValue(5063));
            // hashcode
            Console.WriteLine(ht1.Count);





        }
    }*/

    /////////////////////////////////////////////
    // stack non generic collections 
    /*
    public class Program
    {



        static void Main(string[] args)
        {




            Console.WriteLine("All About Non-Generics Collection");
            Stack s = new Stack();
            s.Push("Ali");
            s.Push("Aslam");
            s.Push(12);
            Console.WriteLine(s.Count);
            Console.WriteLine(s.Peek);
            Console.WriteLine(s.Contains("Ali"));
            // s.Clear();//clear all data from stack
            foreach (object x in s)
            {
                Console.WriteLine(x);

            }  


        }
    }*/

    /////////////////////////////////////////////
    // Que non generic collections 
    /*
    public class Program
    {



        static void Main(string[] args)
        {




            Console.WriteLine("All About Non-Generics Collection");
                Queue q = new Queue();
                q.Enqueue("Ali Hassan");
                q.Enqueue("Sabar");
                q.Enqueue(123);
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Count);
                Console.WriteLine(q.Peek);
                foreach (object item in q)
                {
                    Console.WriteLine(item);
                }

        }
    }
        */

    /////////////////////////////////////////////
    // Diffrence betweeen Generics and non Generics
   
    public class Program
    {



        static void Main(string[] args)
        {




            Console.WriteLine("All About Non-Generics Collection");
            int[] arr = new int[4];
            arr[0] = 2;


        }
    }
        
}