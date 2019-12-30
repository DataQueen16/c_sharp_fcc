using System;

namespace freecodecamp_project
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVariables();
            Console.ReadLine();
        }

        static void GetVariables()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Calculator(num1, op, num2));
        }

        static double Calculator(double num1, string op, double num2)
        {
            double result = 0.00;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Please choose one of the following: +, -, *, /");
                    GetVariables();
                    break;
            }

            return result;
        }
    }
}
