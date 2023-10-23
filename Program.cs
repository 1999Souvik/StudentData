using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateAndWriteTextFile();

            OpenAndReadTextFile();

            
            

            Console.Read();


        }


        private static void OpenAndReadTextFile()
        {

            bool ans = File.Exists(@"C:\Users\Admin\Desktop\Practice_Exercise\Demos\StudentData\bin\Debug\studentdata.txt");
            if (ans == true)
            {

                try
                {

                    FileStream Fs = new FileStream(@"C:\Users\Admin\Desktop\Practice_Exercise\Demos\StudentData\bin\Debug\studentdata.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;

                    try
                    {

                        reading = new StreamReader(Fs);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Fs.Close();
                        Fs.Dispose();
                        reading.Close();
                        reading.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File does'nt exist on the given location");
            }
        }

        private static void CreateAndWriteTextFile()
        {

            FileStream Fs = new FileStream(@"C:\Users\Admin\Desktop\Practice_Exercise\Demos\StudentData\bin\Debug\studentdata.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(Fs);

            try
            {
                writer.WriteLine("Name of the Student :  khushal");
                writer.WriteLine("Student id : 101");
             

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                writer.Flush();

                writer.Close();
                writer.Dispose();
                Fs.Close();
                Fs.Dispose();
            }
        }

    }
}



