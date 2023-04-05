using System.Diagnostics;
using System.Text;

namespace _14String_and_StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String and String Builders");
            /*
            // Normal string 
            string s = "Ali";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                s=s+i;
            }
            sw.Stop();
            */
            // strings are the value based and strings are immutable
            // string builder
            /*
            StringBuilder sb = new StringBuilder("Hello");
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i=0; i<100000; i++)
            {
                sb.Append(i);
            }
            sw1.Stop();
            Console.WriteLine("Time taken by string{0}",sw.ElapsedMilliseconds);
            Console.WriteLine("Time taken by stringBuilder{0}", sw1.ElapsedMilliseconds);
            */
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("Ali");
            sb.AppendLine("Hassan");
            sb.Append("Akram");
            sb.AppendFormat("{0:C}", 23);
            sb.AppendFormat("{0:N}", 23);
            sb.AppendFormat("{0:X}", 23);
            Console.WriteLine(sb);
            sb.Insert(4, "MR");
           sb.Remove(4, 5);
            sb.Replace("Hello", "Hy");
            Console.WriteLine(sb);

        }
    }
}