using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    class Task7
    {
        public static IsOdd[] OddOrEven(double[] array)
        {
            List<IsOdd> result = new List<IsOdd> { };
            for (int i = 0; i < array.Length; i++)
            {                
                result.Add(new IsOdd(array[i]));                
            }

            return result.ToArray<IsOdd>();
        }
    }
}
