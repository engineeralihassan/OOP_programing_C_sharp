namespace Delegates
{

    // Delegates in C#
    // Delegates are hold reference of methods
    // we can call a method by its Reference
    // reference type delegates are

    /*
    public delegate void Calc(int a, int b);
    // single casr delegate
    public delegate void Singledel();
    /*
        public class Program5
        {
            public static void single()
            {
                Console.WriteLine("This function is called by single delegate");
            } 
            public static void addition(int a, int b)
            {
                Console.WriteLine("The A is : {0} and b is :{1}",a,b);



            }
            // subtraction
            public static void sub(int a, int b)
            {
                Console.WriteLine("The A is : {0} and b is :{1}", a, b);

            }
            // mul
            public static void mul(int a, int b)
            {
                Console.WriteLine("The A is : {0} and b is :{1}", a, b);

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Ali Delegates Finish Today ");
                Calc obj = new Calc(Program5.addition);
                obj.Invoke(12, 34);
                obj = sub;
                obj(12, 56);
                obj = mul;
                obj(90, 78);
                // its called only the single functions
                Singledel p = new Singledel(Program5.single);
                p();







            }
        }*/
    /////////////////////////////////////////////////
    ///  Types of Delegates     

    //  multiple delegates

    public delegate void Calc(int a, int b);
    public delegate void def();
    // multicast delegates
    public delegate void Mcasr(int a, int b);

    public class Program5
    {
        public static void single()
        {
            Console.WriteLine("This function is called by single delegate");
        }
        // 3 parameter func
        public static void add(int a, int b,string c)
        {
            Console.WriteLine("The A is : {0} and b is :{1}={2}", a, b,c);



        }
        public static void addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is :{0} ",c);

        }
        // subtraction
        public static void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("The sub is :{0} ", c);
        }
        // mul
        public static void mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("The Mul is :{0} ", c);
          

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ali Delegates Finish Today ");
            //Calc obj = new Calc(Program5.addition);
            //obj(45, 78);
            // without parameter function delegate

            //def p = new def(single);
            //p();

            // multicast delegates objects
            Calc obj = new Calc(Program5.addition);
            obj += sub;
            obj += mul;
            obj(45, 67);
            








        }
    }









}