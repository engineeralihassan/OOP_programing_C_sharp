namespace _16_Structures
{
    struct Program
    {
        int a;
        public Program(int i)
        {
            this.a = i;
            Console.WriteLine("Structure in structs"+a);
        }
        
        public void func1()
        {
            Console.WriteLine("This is function one");

        } 
        static void Main(string[] args)
        {
            Console.WriteLine("structures in c#");
            Program p = new Program(12);
            // also make the object with out new keyword
            Program p2 ;
            p2.a = 12;

            p.func1();
            p2.func1();

        }
    }

    interface myinterface
    {
        void f();
    }
    struct mystrct : myinterface
    {
        public void f()
        {
            Console.WriteLine("This is the interface" +
                " methods implemented in struct");
        }
    }
}