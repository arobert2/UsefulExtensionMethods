using System;
using System.Collections.Generic;
using System.Text;

namespace UsefulExtensionMethods.GeneralExtensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get the first day of the week in relation to a supplied DateTime object
        /// </summary>
        /// <param name="dateTime">Reference DateTime object.</param>
        /// <returns>First day of week</returns>
        public static DateTime FirstDayOfWeek(this DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                return dateTime;

            var weekindex = (int)dateTime.DayOfWeek;
            var sunday = dateTime.Subtract(new TimeSpan(weekindex, 0, 0, 0));
            return sunday;
        }
        /// <summary>
        /// Get the last day of a week in relation to the supplied DateTime object
        /// </summary>
        /// <param name="dateTime">DateTime reference</param>
        /// <returns>Last day of week.</returns>
        public static DateTime LastDayOfWeek(this DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Friday)
                return dateTime;

            var weekindex = (int)dateTime.DayOfWeek;
            var saturday = dateTime.Add(new TimeSpan(6 - weekindex, 0, 0, 0));
            return saturday;
        }

        /// <summary>
        /// Rounds time to the nearest half hour
        /// </summary>
        /// <param name="dateTime">DateTime to round</param>
        /// <returns>Rounded DateTime</returns>
        public static DateTime RoundToQuarter(this DateTime dateTime)
        {
            var minute = dateTime.Minute;
            if (minute <= 7)
                minute = 0;
            else if (minute > 7 && minute <= 21)
                minute = 15;
            else if (minute > 21 && minute <= 37)
                minute = 30;
            else if (minute > 37 && minute <= 52)
                minute = 45;
            else if (minute > 52)
                minute = 0;

            var dt = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, minute, dateTime.Second, dateTime.Millisecond);
            return dt;
        }
    }
}
