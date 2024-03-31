using System;

namespace CW7
{
    internal struct Birthday
    {
        private DateTime birthDate;

        public Birthday(int year, int month, int day)
        {
            birthDate = new DateTime(year, month, day);
        }

        public DayOfWeek DayOfWeekOfBirth()
        {
            return birthDate.DayOfWeek;
        }

        public DayOfWeek DayOfWeekInYear(int year)
        {
            DateTime birthdayInYear = new DateTime(year, birthDate.Month, birthDate.Day);
            return birthdayInYear.DayOfWeek;
        }

        public int DaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - today).Days;
        }
    }
}