using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_1
{
    static class Math
    {
        static public int Max(this Set arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Len; i++)
            {
                max = arr[i] > max ? arr[i] : max;
            }
            return max;
        }
        
        static public int Min(this Set arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Len; i++)
            {
                min = arr[i] < min ? arr[i] : min;
            }
            return min;
        }

        public static int Sum(this Set arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Len; i++)
                sum += arr[i];
            return sum;
        }
    }
}
