using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TribonnicServicesWebAPIwithTestCases.Models
{
    public class Tribonnice
    {
        /// <summary>
        /// Get series values
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetValues(int number)
        {
            int result = 0;
            int a, b, c;

            a = 1; b = 1; c = 1;

            if (number == 0) result = a;
            if (number == 1) result = b;
            if (number == 2) result = c;
            while (number > 2)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                number--;
            }

            return result;
        }
    }
}