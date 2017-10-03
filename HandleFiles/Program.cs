using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandleFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Jp\Desktop\tree.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("test1");
                    sw.WriteLine("test2");
                    sw.WriteLine("test3");
                    sw.WriteLine("test4");
                    sw.WriteLine("test5");
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s = string.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
