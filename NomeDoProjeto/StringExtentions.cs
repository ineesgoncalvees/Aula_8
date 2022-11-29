using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace NomeDoProjeto
{
    public static class StringExtentions
    {
        private static Random random;

        static StringExtentions()
        {
            random = new Random();
        }

        /*
        public static string ToRandomCase(this string s)
        {
            string newString = "";

            foreach(char c in s)
            {
                if(random.NextDouble() < 0.5)
                    newString += char.ToUpper(c);
                else
                    newString += char.ToLower(c);
            }

            return newString;
        }
        */

        public static string ToRandomCase(this string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in s)
            {
                if(random.NextDouble() < 0.5)
                    sb.Append (char.ToUpper(c));
                else
                    sb.Append (char.ToLower(c));
            }

            return sb.ToString();
        }
    }
}