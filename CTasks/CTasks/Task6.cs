using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTasks
{
    class Task6
    {
        //public static Words[] _listOfWords { get; set; }

        public static Words [] findWords(String str, string[] arr)
        {
            int k = 0;
            int pos = 0;
            int i;
            string[] _listOfWords = new string[str.Split(' ').Length];            
            List<Words> list = new List<Words> { };
            str = str.ToLower();
            str = Regex.Replace(str, @"[.,\/#!$%\^&\*;:{}=\-_`~()]", " ");
            str = Regex.Replace(str, @"[ ]{2,}", " ");
            str = str.Trim();

            _listOfWords = str.Split(' ');
            for (i = 0; i < arr.Length; i++)
            {
                k = 0;
                foreach (string word in _listOfWords)
                {
                    if (word == arr[i])
                        k++;
                }
                list.Add(new Words (arr[i], k));
                
            }

            return list.ToArray<Words>();
            
            
            /*
            for (i = 0; i < arr.Length; i++)
            {
                k = 0;
                for (pos = 0; pos < str.Length; pos++)
                {
                    if (n[pos] == arr[i])
                        k++;
                }
                objec[i].word = n[pos];
                objec[i].count = k;
                list.Add(objec[i]);
            }

            return list.ToArray<words>();*/
        }
    }
}
