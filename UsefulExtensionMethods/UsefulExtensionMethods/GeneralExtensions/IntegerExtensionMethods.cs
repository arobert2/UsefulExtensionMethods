using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulExtensionMethods.GeneralExtensions
{
    public static class IntegerExtensions
    { 
        private enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        /// <summary>
        /// Convert integer between 1 and 12 to Month namme.
        /// </summary>
        /// <param name="month">Month value</param>
        /// <returns>Name as string</returns>
        public static string ToMonthName(this int month)
        {
            var checkedMonth = 0;
            if (month > 0)
                checkedMonth = month % 12 == 0 ? 12 : month % 12;
            if (month < 0)
                checkedMonth = month % 12 + 12 == 0 ? 12 : month % 12 + 12;
            if (month == 0)
                checkedMonth = 12;
            return ((Month)checkedMonth).ToString();
        }
    }
}
