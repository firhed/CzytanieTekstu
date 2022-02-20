using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int obieg = 1;
            while (obieg <= 16)
            {
                string filePath = @"Words.txt";
                var lines = File.ReadAllLines(filePath);
                var r = new Random();
                var randomLineNumber = r.Next(0, lines.Length - 1);
                var line = lines[randomLineNumber];
                string used = null;

                int podwojenie = 0;
                if(line != used)
                {
                    while (podwojenie < 2)
                    {
                        podwojenie++;
                        Console.WriteLine(obieg + ". " + line);
                    }
                    line = used;
                    obieg++;
                }
                
            }
        
            Console.ReadKey();
        }
    }
}
