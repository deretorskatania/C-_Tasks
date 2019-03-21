using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTasks
{
    class Task4
    {
        public string _str { get; set; }
        public Task4(string str) {
            _str = str;
        }
        public int wordsCounter
        {
            get
            {
                _str = Regex.Replace(_str, @"[.,\/#!$%\^&\*;:{}=\-_`~()]", " ");
                _str = Regex.Replace(_str, @"[ ]{2,}", " ");
                _str = _str.Trim();
                return _str.Split(' ').Length;
            }
        }
    }
}
