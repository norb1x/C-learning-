using System;

namespace KalkulatorOperacjiMatematycznych
{
    class Program
    {
        static void Main(string[] args)
        {
            MathCalculator calculator = new MathCalculator();

            // Wprowadź liczby i wybierz operację
            Console.WriteLine("Wprowadź pierwszą liczbę:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź drugą liczbę:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Wybór operacji
            Console.WriteLine("Wybierz operację: (+, -, *, /)");
            string operation = Console.ReadLine();

            // Ustawienie operacji
            switch (operation)
            {
                case "+":
                    calculator.SetOperation(new AdditionOperation());
                    break;
                case "-":
                    calculator.SetOperation(new SubtractionOperation());
                    break;
                case "*":
                    calculator.SetOperation(new MultiplicationOperation());
                    break;
                case "/":
                    calculator.SetOperation(new DivisionOperation());
                    break;
                default:
                    Console.WriteLine("Nieznana operacja.");
                    return;
            }

            // Wykonanie operacji
            try
            {
                double result = calculator.ExecuteOperation(num1, num2);
                Console.WriteLine($"Wynik operacji: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}
