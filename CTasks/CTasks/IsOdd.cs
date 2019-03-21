using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    public class IsOdd
    {
        public double _n { get; set; }
        public bool _isOdd { get; set; }

        public IsOdd(double n) {
            _n = n;
        }      

        public bool OddOrEven (double _n){
            if (_n % 2 != 0) { _isOdd=true; }
            else { _isOdd=false; }
            return _isOdd;
        }
        public void print()
        {
            Console.WriteLine("Num: \n {0},\n  IsOdd: {1},\n ", _n, OddOrEven(_n));
        }


    }
}
