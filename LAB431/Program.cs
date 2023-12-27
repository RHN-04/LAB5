using LAB431;
using System;

namespace LAB431
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату рождения в формате (гггг-мм-дд): ");
            string inputBirthDate = Console.ReadLine();
            if (DateTime.TryParse(inputBirthDate, out DateTime birthDate))
            {
                DateTime currentDate = DateTime.Now;

                int age = AgeCalculator.CalculateAge(birthDate, currentDate);
                int daysUntilNextBirthday = AgeCalculator.DaysUntilNextBirthday(birthDate, currentDate);

                Console.WriteLine($"Возраст: {age} лет");
                Console.WriteLine($"Дней до следующего дня рождения: {daysUntilNextBirthday}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод даты.");
            }
        }
    }
}
