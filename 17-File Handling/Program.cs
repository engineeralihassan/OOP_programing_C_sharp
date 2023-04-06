using System.Text;

namespace _17_File_Handling
{
    /* internal class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("File Handling in C#");
             string path = @"D:\data.txt";
             string path2 = @"D:\collection.txt";
             if (File.Exists(path))
             {
                 Console.WriteLine("This File is exist ");
                 // wread data from file
                 string data = File.ReadAllText(path);
                 Console.WriteLine(data);
                 // mak copy of the filei
                 File.Copy(path, path2);
                 // copy method overloaded version
                 // it allows us to create the compy of the same existing files
                 // File.Copy(path, path2, true);

             }
             else
             {
                 Console.WriteLine("File not found");
             }
         }
     }
         */
    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Handling in C#");
            string path = @"D:\My Directory";
            string path2 = @"D:\My Directory 2";
            string path3 = @"D:\Downloads";

            // DirectoryInfo dir = new DirectoryInfo(path3);
            //dir.Create();
            //dir.CreateSubdirectory( "Inside Folder");
            //dir.MoveTo(path2);
            // dir.Delete(true);
            //DirectoryInfo[] dirs = dir.GetDirectories();
            //Console.WriteLine("Directory is created");
            //foreach( var item in dirs)
            //{
            //    Console.WriteLine(item);
            //    // Console.WriteLine(item.GetDirectories().Length);
            //    Console.WriteLine(item.GetFiles().Length);
            //}

            ///////////////////////////
            ///// properties 
            DirectoryInfo dir = new DirectoryInfo(path3);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.LastWriteTime);


        }
    }
    */
    /// <summary>
    /// /////////////////////////////////////////
    /// File straem class 
    /// open close read write in files  
    public class Program
    {
        static void Main(string[] args)
        {

            //  string path3 = @"D:\myFile.txt";

            //FileStream fs = new FileStream(path3, FileMode.Create);
            //fs.Close();
            //  DirectoryInfo dir = new DirectoryInfo(path3);
            //using (FileStream fs =
            //    new FileStream(path3,
            //    FileMode.Create,FileAccess.Write))
            //{
            //    fs.WriteByte(66);
            //    Console.WriteLine("File is created");
            //}
            //////////////////  append data not create file
            //using (FileStream fs =
            // new FileStream(path3,
            // FileMode.Open, FileAccess.Write))
            //{
            //    fs.WriteByte(66);
            //    fs.WriteByte(67);
            //    fs.WriteByte(68);
            //    Console.WriteLine("File is created");
            //}
            ///////////////////
            ///
            /*
               using (FileStream fs =
            new FileStream(path3,
            FileMode.Append, FileAccess.Write))
            {


                string data = " please start learn fro " +
                    "learning never ends becuase " +
                    "the mr addil is a beautifull" +
                    " instructor ";
                byte[] write_data = Encoding.UTF8.GetBytes(data);
                fs.Write(write_data, 0, write_data.Length);
                Console.WriteLine("data added");

            }
               */
            ///////////////////////////////////////
            // stream writer class used for write file only

            //string path3 = @"D:\myFile.txt";
            //using(FileStream fs =
            //new FileStream(path3,
            //FileMode.Create, FileAccess.Write))
            //{


            //    using (StreamWriter sr = new StreamWriter(fs,Encoding.UTF8))
            //    {
            //        sr.WriteLine("try to finsh .Net in next 15 days ");

            //        sr.WriteLine("First try to finish you Full stack developement " +
            //            "course then move to the next level or making projects  ");
            //    }
            //    Console.WriteLine("File created");
            //}
            ///////////////////////////////////////
            // stream reader used for read data from file
            string path3 = @"D:\myFile.txt";
            using (FileStream fs =
            new FileStream(path3,
            FileMode.Open, FileAccess.Read))
            {


                using (StreamReader sr = new StreamReader(fs))
                {
                    // read First Line
                    //string da = sr.ReadLine();
                    //Console.WriteLine(da);
                    // Read all data
                    string line = ""; 
                     
                    while((line=sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine("File created");
            }



        }
    }
}