namespace _11_Exceptional_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Exceptional Handling in  c#");
            Console.WriteLine("Enter number 1");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            //////////////////////////
            /// dive by zeor
            try
            {
                int div = num1 / num2;
                Console.WriteLine("Divition is :{0}", div);
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("We can not divide" +
                    " a number by zero");
                Console.WriteLine(ex.Message);
            }
{ }     
        
            Console.WriteLine("lest expressions");
            Console.WriteLine("lest expressions");
            Console.WriteLine("lest expressions");
            Console.WriteLine("lest expressions");
            ///////////////////////////////////////////
            /// index out of range
            int[] arr = new int[3];
            try
            {
                arr[0] = 12;
                arr[1] = 13;
                arr[2] = 14;
                arr[3] = 15;
                arr[4] = 16; // exeptiones line

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Array is out of range ");

            }

            // nul reference Expresions
            string name = "Ali hassan";
            try
            {
                Console.WriteLine(name.Length);
            }catch(NullReferenceException ex)
            {
                Console.WriteLine("Your variable is null ");
                Console.WriteLine(ex.Message);
            }
            // formate exceptions
            string number = Console.ReadLine();
            try
            {
                int num = int.Parse(number);
                Console.WriteLine("nymber is {0}", num);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("string formate is invalid ");
            }
            */
            // Exception class in  
            /*
            try
            {
                string a = null;
                Console.WriteLine(a.Length);
                int c = 12, b = 0;
                int d = c / b;



            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            // try catch with finaly block
            try
            {
                int[] arr = new int[3];
                arr[3] = 12;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("We done all Work");
            }

            // ways  of exceptions
            // our throw and default catch
            //Console.WriteLine("Enter your age ");
            //int age = int.Parse(Console.ReadLine());
            //if (age > 18)
            //{
            //    Console.WriteLine("You eligible to cast vote");
            //}
            //else
            //{
            //    throw new Exception("you are not eligible to vote");
            //}
            // our throw and our catch
            try
            {
                Console.WriteLine("Enter your age ");
                int age = int.Parse(Console.ReadLine());
                if (age > 18) 
                {
                    Console.WriteLine("You eligible to cast vote");
                }
                else
                {
                    throw new Exception("you are not eligible to vote");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }








        }
    }
}