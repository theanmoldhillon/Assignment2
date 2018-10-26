using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models.ExtensionMethod
{
    public class AgeCalculator
    {
        public int ToAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }
    }
}