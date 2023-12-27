using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB431
{
    [TestFixture]
    internal class AgeCalculatorTests
    {
        [Test]
        public void CalculateAge_ShouldReturnCorrectAge()
        {
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime currentDate = new DateTime(2022, 2, 1);

            int age = AgeCalculator.CalculateAge(birthDate, currentDate);

            Assert.AreEqual(22, age);
        }

        [Test]
        public void DaysUntilNextBirthday_ShouldReturnCorrectDays()
        {
            DateTime birthDate = new DateTime(2000, 5, 1);
            DateTime currentDate = new DateTime(2022, 1, 1);

            int daysUntilNextBirthday = AgeCalculator.DaysUntilNextBirthday(birthDate, currentDate);

            Assert.AreEqual(120, daysUntilNextBirthday);
        }

        [Test]
        public void CalculateAge_ShouldReturnCorrectAge_NoBirthdayYet()
        {
            DateTime birthDate = new DateTime(2001, 10, 8);
            DateTime currentDate = new DateTime(2022, 1, 1);

            int age = AgeCalculator.CalculateAge(birthDate, currentDate);

            Assert.AreEqual(20, age);
        }

        [Test]
        public void CalculateAge_ShouldReturnCorrectAge_NoBirthdayYet2()
        {
            DateTime birthDate = new DateTime(2001, 10, 8);
            DateTime currentDate = new DateTime(2022, 10, 1);

            int age = AgeCalculator.CalculateAge(birthDate, currentDate);

            Assert.AreEqual(20, age);
        }

        [Test]
        public void DaysWhenCurrentDateIsAfterBirthday_ShouldReturnCorrectDays()
        {
            DateTime birthDate = new DateTime(2000, 1, 31);
            DateTime currentDate = new DateTime(2022, 2, 1);

            int daysUntilNextBirthday = AgeCalculator.DaysUntilNextBirthday(birthDate, currentDate);

            Assert.AreEqual(364, daysUntilNextBirthday);
        }
    }
}
