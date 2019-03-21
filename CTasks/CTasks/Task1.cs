using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    class Task1
    {
        public double _a { get; set; }
        public double _b { get; set; }

       

        public Task1(double a, double b) {
            _a = a;
            _b = b;
        }

        public double chooseBigger
        {
            get
            {

                if (_a > _b)
                {
                    return _a;
                }
                else
                {
                    return _b;
                }
            }
        }       

        
    }
}
