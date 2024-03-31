using System;

namespace CW7
{
    internal class MainMethods
    {
        public static void Task1Main()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);

            Console.WriteLine($"Дріб 1: {fraction1}");
            Console.WriteLine($"Дріб 2: {fraction2}");

            Fraction sum = fraction1 + fraction2;
            Console.WriteLine($"Сума: {sum}");

            Fraction difference = fraction1 - fraction2;
            Console.WriteLine($"Різниця: {difference}");

            Fraction product = fraction1 * fraction2;
            Console.WriteLine($"Добуток: {product}");

            Fraction quotient = fraction1 / fraction2;
            Console.WriteLine($"Частка: {quotient}");
        }

        public static void Task2Main()
        {
            ComplexNumber num1 = new ComplexNumber(2, 3);
            ComplexNumber num2 = new ComplexNumber(1, 2);

            Console.WriteLine($"Комплексне число 1: {num1}");
            Console.WriteLine($"Комплексне число 2: {num2}");

            ComplexNumber sum = num1 + num2;
            Console.WriteLine($"Сума: {sum}");

            ComplexNumber difference = num1 - num2;
            Console.WriteLine($"Різниця: {difference}");

            ComplexNumber product = num1 * num2;
            Console.WriteLine($"Добуток: {product}");

            ComplexNumber quotient = num1 / num2;
            Console.WriteLine($"Частка: {quotient}");
        }

        public static void Task3Main()
        {
            Birthday birthday = new Birthday(2000, 4, 1);

            Console.WriteLine("День тижня, коли народився іменинник: " + birthday.DayOfWeekOfBirth());

            int year = 2025;
            Console.WriteLine($"День тижня у {year} році, коли буде день народження: {birthday.DayOfWeekInYear(year)}");

            Console.WriteLine($"До наступного дня народження залишилося {birthday.DaysUntilBirthday()} днів.");
        }
    }
}