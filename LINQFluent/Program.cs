using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            //private const string TxtUrl = "http://textfiles.com/stories/roger1.txt";

            string[] text = File.ReadAllLines("roger1.txt");

            int lineCount = text.Count(s => s.Length > 30);

            Console.WriteLine(lineCount);

            double lineAvg = text.Average(s => s.Length);

            Console.WriteLine(lineAvg);

            bool plus120 = text.Any(s => s.Length > 120);

            Console.WriteLine(plus120);

            IEnumerable <string> idk = text
                .Where(s => s.Contains("Y"))
                .Select(s => s.Trim().Split()[0].ToUpper());

            foreach(string s in idk)
            {
                Console.WriteLine(s);
            }

            IEnumerable <string> stuff =
                from s in text
                where s.Contains("Y")
                select s.Trim().Split()[0].ToUpper();

            foreach(string s in stuff)
            {
                Console.WriteLine(s);
            }
        }
    }
}
