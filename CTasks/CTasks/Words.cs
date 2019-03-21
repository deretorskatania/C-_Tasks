using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTasks
{
    public class Words
    {   
        public string _word { get; set; }
        public int _count { get; set; }

        public Words() { }

        public Words(string word, int count) {
            _word = word;
            _count = count;
        }

        public void print() {
            Console.WriteLine("Word: \n {0},\n  Count: {1},\n ", _word, _count);
        }

        /*public override string ToString()
        {
            return string.Format("Word: \n {0},\n  Count: {1},\n ", _word, _count);
        } */

         
    }
}
