using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Utils
{
    public class Validators
    {
        //something like that

        public static void StringValidator(string input, int minLength, int maxLength, string message)
        {
            if (input.Length <= minLength || input.Length >= maxLength || input == null)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void NumberValidator(IComparable input, IComparable minValue, IComparable maxValue, string message)
        {
            if (input.CompareTo(minValue) <= 0 || input.CompareTo(maxValue) >= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }


    }
}
