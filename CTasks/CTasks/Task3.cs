using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    class Task3
    {
        /*public static double[] _myArray { get; set; }
        public double _minVal { get; set;}
        public double _maxVal { get; set; }

        public Task3(double[] myArray, double minVal, double maxVal)
        {
            _myArray = myArray;
            _minVal = minVal;
            _minVal = maxVal;            
        }*/

        public static double[] filterArray(double[] _myArray, double _minVal, double _maxVal)
        {
            //get{

                List<double> arr = new List<double>();
                int k = 0;
                int i = 0;
                for (i = 0; i < _myArray.Length; i++)
                {
                    if ((_myArray[i] > _minVal) && (_myArray[i] < _maxVal))
                    {
                        arr.Add(_myArray[i]);
                        k++;
                    }
                }
                return arr.ToArray<double>();
            //}
        }
    }
}
