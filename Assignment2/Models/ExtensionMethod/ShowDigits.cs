using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Assignment2.Models.ExtensionMethod
{
    public static class ShowDigits
    {
        public static bool ToAge(this string value)
        {
            Regex regex = new Regex(@"[0-9]");
            return regex.IsMatch(value);
        }
    }
}