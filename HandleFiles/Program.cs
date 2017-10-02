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
            string path = @"C:\Users\Jp\Desktop\Quiz_folder\Guessing_game_ soulution.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
