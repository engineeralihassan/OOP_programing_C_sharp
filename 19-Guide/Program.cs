namespace _19_Guide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Globally unique identifier");
            Guid g = Guid.NewGuid();
            //Console.WriteLine(g.ToString().
            //    Replace("-", string.Empty));
           // Console.WriteLine(g.ToString("N"));
            Console.WriteLine(g.ToString("N").Substring(0,15) );
            Console.WriteLine(g);

        }
    }
}