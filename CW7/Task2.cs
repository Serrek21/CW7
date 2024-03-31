using System;

namespace CW7
{
    internal struct ComplexNumber
    {
        public double RealPart;
        public double ImaginaryPart;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.RealPart + num2.RealPart;
            double imag = num1.ImaginaryPart + num2.ImaginaryPart;
            return new ComplexNumber(real, imag);
        }

        // Метод для віднімання комплексних чисел
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.RealPart - num2.RealPart;
            double imag = num1.ImaginaryPart - num2.ImaginaryPart;
            return new ComplexNumber(real, imag);
        }

        // Метод для множення комплексних чисел
        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.RealPart * num2.RealPart - num1.ImaginaryPart * num2.ImaginaryPart;
            double imag = num1.RealPart * num2.ImaginaryPart + num1.ImaginaryPart * num2.RealPart;
            return new ComplexNumber(real, imag);
        }

        // Метод для ділення комплексних чисел
        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double divisor = num2.RealPart * num2.RealPart + num2.ImaginaryPart * num2.ImaginaryPart;
            double real = (num1.RealPart * num2.RealPart + num1.ImaginaryPart * num2.ImaginaryPart) / divisor;
            double imag = (num1.ImaginaryPart * num2.RealPart - num1.RealPart * num2.ImaginaryPart) / divisor;
            return new ComplexNumber(real, imag);
        }

        // Перевизначення методу ToString() для зручного виводу комплексного числа
        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }
    }
}