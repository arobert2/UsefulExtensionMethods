using System;
using System.Collections.Generic;
using System.Text;

namespace UsefulExtensionMethods.WebExtensions
{
    public static class DateTimeToHtml
    {
        /// <summary>
        /// Gets a date formatted for html input date value.
        /// </summary>
        /// <param name="dateTime">DateTime object you need to get date from./param>
        /// <returns>Date formatted for html date value.</returns>
        public static string ToHtmlDate(this DateTime dateTime)
        {

            var sb = new StringBuilder();
            sb.Append(dateTime.Year).Append('-');

            if (dateTime.Month < 10)
                sb.Append('0').Append(dateTime.Month).Append('-');
            else
                sb.Append(dateTime.Month).Append('-');

            if (dateTime.Day < 10)
                sb.Append('0').Append(dateTime.Day);
            else
                sb.Append(dateTime.Day);

            return sb.ToString();
        }
        /// <summary>
        /// Gets a time formatted for html input time value.
        /// </summary>
        /// <param name="dateTime">DateTime object to get time from.</param>
        /// <returns>Time formatted for html time value.</returns>
        public static string ToHtmlTime(this DateTime dateTime)
        {
            var hour = dateTime.Hour < 10 ? "0" + dateTime.Hour : dateTime.Hour.ToString();
            var minute = dateTime.Minute < 10 ? "0" + dateTime.Minute : dateTime.Minute.ToString();
            var timeAsString = new StringBuilder()
                .Append(hour)
                .Append(':')
                .Append(minute)
                .ToString();

            return timeAsString;
        }
    }
}
