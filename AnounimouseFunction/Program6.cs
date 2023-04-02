namespace AnounimouseFunction
{
    /*
        public delegate void Calc(int a, int b);
        public delegate int Recalc(int a, int b);
        public class Program6
        {

            static void Main(string[] args)
            {
                Console.WriteLine("All about Anounimouse Functions");
                Calc obj = delegate (int a, int b)
                {
                    a = a + b;
                    Console.WriteLine("The sum is : {0}", a);
                };
                obj(12, 45);
                Recalc p = delegate (int a, int b)
                {
                    a = a + b;
                    Console.WriteLine("The sum is : {0}", a);
                    return a;
                };
                Console.WriteLine("Return is : {0} ", p(12, 45));
            }
        }

        */
    ///////////////////////////////////////////////    //////////////
    ///    Lambda expressions

    public delegate void Calc(int a, int b);
    public delegate int  Cal(int a, int b);
    public class Program6
    {

        static void Main(string[] args)
        {
            Console.WriteLine("All about Anounimouse Functions");
            Calc obj = delegate (int a, int b)
            {
                a = a + b;
                Console.WriteLine("The sum is : {0}", a);
            };
            obj(12, 45);
            //   lambda 
            Calc lambda = (int a, int b) =>
            {
                a = a + b;
                Console.WriteLine("The lambda functions is ", a);
            };
            lambda(12, 45);
            // expresion lambda
            Cal explambda = ( a, b) => a = a + b;

            Console.WriteLine(explambda(12, 34));

            


        }


    }






}