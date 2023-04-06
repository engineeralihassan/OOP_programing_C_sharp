namespace _18_Boxing_unBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing and unBoxing In C#");
            // Boxing means implicitly type convertions
            int num1 = 21;
            object obj = num1;
            Console.WriteLine(obj);
            // int num2=obj this is error
            int num2 =(int) obj;
        }
    }
}