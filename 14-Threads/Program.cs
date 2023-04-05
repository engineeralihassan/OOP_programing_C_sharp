namespace _14_Threads
{
   public class Program
    {
        public static void func1()
        {
            for (int i = 1; i <50; i++)
            {
                Console.WriteLine("Func1 calls"+i);
            }
        }
        //
        public static void func2()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Func12 calls" + i);
                if(i == 25)
                {
                    Console.WriteLine("thread is on sleep");
                    Thread.Sleep(8000);
                }
            }
        }
        //
        public static void func3()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Func3 calls" + i);
            }
        }
        static void Main(string[] args)
        {
         
            Console.WriteLine("Multi threading in c#");
            /*
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";

            Console.WriteLine("Current executing Thread is {0}",t.Name);
            */
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);
            t1.Start();
            t2.Start();
            t3.Start();
            //Program.func1();
            //Program.func2(); 
            //Program.func3();

        }
    }
}