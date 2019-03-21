using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    class Task2
    {
        public double[] _myArray { get; set; }
        public Task2(double[] myArray) {
            _myArray = myArray;
        }

        public double findMax
        {
            get
            {
                var max = _myArray[0];
                for (var i = 1; i < _myArray.Length; i++)
                {
                    if (_myArray[i] > max)
                    {
                        max = _myArray[i];
                    }

                }
                return max;
            }
        }

        public double findMin
        {
            get
            {
                double min = _myArray[0];
                for (var i = 1; i < _myArray.Length; i++)
                {
                    if (_myArray[i] < min)
                    {
                        min = _myArray[i];
                    }

                }
                return min;
            }
        }
    }
}
