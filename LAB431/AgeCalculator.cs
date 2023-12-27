using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB431
{
    internal class AgeCalculator
    {
        public static int CalculateAge(DateTime birthDate, DateTime currentDate)
        {
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        public static int DaysUntilNextBirthday(DateTime birthDate, DateTime currentDate)
        {
            DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
            if (currentDate > nextBirthday)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            return (int)(nextBirthday - currentDate).TotalDays;
        }
    }

}