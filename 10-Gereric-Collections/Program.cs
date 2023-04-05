namespace _10_Gereric_Collections
{
    // Generics collection
    // List Stack , Que ; Dictionary
    /// <List>
    /// ///////////////////////////////////////////////////
    /// used to assign any data type once you give the int then its accept only int
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All about Generics collections ");
            /*///////////////////////////////////
            List<int> li = new List<int>();
          
            li.Add(13456);
            li.Add(12456);
            li.Add(12);
            li.Add(1345632190);
            li.Sort();
            foreach (int item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            List<string> l1 = new List<string>();
            l1.Add("Ahsan");
            l1.Add("Adeel ");
            l1.Add("Ali");
            l1.Add("Ahmad hassan");
            Console.WriteLine(l1[1]);
            // we also give the duplicate values in the list
            List<string> l2 = new List<string>();
            l2.Add("Ali hassan");
            l2.Add("Ali Hassan");
            l2.Add("Ali Hassan");
            l2.Add("Ali Hassan");
            l2.Add("nulain hasan jameel");
           // l2.Add(null);//

            l2.Add("Zain ul abdain");
            l2.Add("halal hassan");
            l2.Add("bazam hassan");
          //  l2.AddRange(l2);
            l2.Sort();
            l2.Insert(3, "Aslam Ghori");
            l2.InsertRange(4, l2);
            Console.WriteLine("--------------------h1");
            Console.WriteLine(l2[3]);
            l2.Remove("bazam hassan");
            l2.RemoveAt(2);
            l2.RemoveAll(emp => emp == "Ali Hassan");
          bool c=  l2.Contains("halal hassan");
            Console.WriteLine(c);
            bool d = l2.Exists(emp => emp.StartsWith("l"));
            Console.WriteLine(d);
            l2.Reverse();
            l2.IndexOf("Ali Hassan");
            l2.IndexOf("Ali Hassan",2);
            l2.LastIndexOf("Ali Hassan");
            //l2.Clear();
            string c2=l2.Find(em => em == "halal hassa");
            Console.WriteLine("Hello "  +c2);
            string c22 = l2.FindLast(em => em == "halal hassan");
            Console.WriteLine("Hello " + c22);
            Console.WriteLine( l2.FindIndex(e => e == "Ali Hassan"));
            





            //  l2.RemoveRange(5, 4);// start from index 5 and remove 5 items
            //  


            // foreach (string item in l2)
            //{
            //    Console.WriteLine(item);
            */
            /////////////////////////////////////////////////////
            ///  Dictionary 
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name", "Ali hassan");
            dic.Add("class", "BSSE-A-Evening");
            dic.Add("roll", "BSSE-19-5063");

            Console.WriteLine(dic["name"]);
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key);

            }
            //
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            myDictionary.Add("apple", 1);
            myDictionary.Add("banana", 2);
            myDictionary.Add("cherry", 3);

            foreach (KeyValuePair<string, int> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            dic.Remove("roll");
            dic.ContainsKey("name");
            dic.ContainsValue("BSSE-A-Evening");
            //dic.Clear()
            string value;
            dic.TryGetValue("name", out value);
            Console.WriteLine(value);
            dic.Add("wife", null);
            //dic.Add("name", "Ali hassan"); error exceptions
             

        }




    } 
}






        
    
