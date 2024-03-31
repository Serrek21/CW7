using System;

namespace CW7
{
    internal struct Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Simplify();
            return result;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Simplify();
            return result;
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Numerator;
            int denominator = fraction1.Denominator * fraction2.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Simplify();
            return result;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            int numerator = fraction1.Numerator * fraction2.Denominator;
            int denominator = fraction1.Denominator * fraction2.Numerator;
            Fraction result = new Fraction(numerator, denominator);
            result.Simplify();
            return result;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}