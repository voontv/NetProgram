using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise02
    {
        public string Capital(string word)
        {

            return Char.ToUpper(word[0]) + word.Substring(1);
        }

        public string UpperCase(string s)
        {

            return string.Concat(s.Split('_').Select(x => Capital(x)));
        }
    }
}
