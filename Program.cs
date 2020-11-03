using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_tecken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Reads this textfile: ");
            //Console.WriteLine("this textfile: C:\\Users\\ludvi\\progmet\\textfilewithtext.txt");
            string path = "C:\\Users\\ludvi\\progmet\\textfilewithtext.txt";
            string[] lines = File.ReadAllLines(@path);
            int rows = 0;
            int countChars = 0;
            int countWords = 0;
            Console.WriteLine($"contents of {path}: ");
            Console.WriteLine("");
            foreach (string line in lines)
            {
                string[] word = line.Split(' ');
                countWords = countWords + word.Length;
                
                foreach (char chr in line)
                {
                    
                    
                    if(!char.IsWhiteSpace(chr))
                    {
                        countChars++;
                    }

                }
                rows++;
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine($"Det är {countWords} ord i textfilen");
            Console.WriteLine($"Det är {rows} rader i textfilen" );
            Console.WriteLine($"Det är {countChars} tecken i textfilen");
            Console.ReadKey();
        }
    }
}
