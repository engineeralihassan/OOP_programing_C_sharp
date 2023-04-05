namespace _12_Parial_Classes
{
  
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partial Class in c#");
            studentPartial obj = new studentPartial();
            obj.FirstName = "Ali";
            obj.lastName = "Hassan";  
            obj.getCompleteName();


        }
    }
}