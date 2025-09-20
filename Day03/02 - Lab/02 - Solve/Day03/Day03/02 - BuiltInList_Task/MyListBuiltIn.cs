using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day03._02___BuiltInList_Task
{
    internal class MyListBuiltIn<T> : List<T>
    {
        public new void Add(T x)
        {
            base.Add(x);
            StreamWriter sw = new StreamWriter("myFile.txt", true);//bin/debug/myFile.txt
            sw.WriteLine(x);
            sw.Close();

        }

        public void ReadFile()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("myFile.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
