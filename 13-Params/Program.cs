namespace _13_Params
{
    public class Program

    {
        public static int add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum = sum + i;
            }
            return sum;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Params in C#");
            Console.WriteLine(Program.add(12,56,34,56,78,90,12,34,56,78,90));
        }
    }
}