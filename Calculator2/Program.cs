using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            double result = 0;

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            // Use methods for each type of calculation.

            Console.Write("Enter a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter a different number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            
            Console.Write("Would you like to add, subtract, multiply or divide these two numbers? ");
            string mathType = Console.ReadLine();


            if (mathType.ToLower() == "add")
                result = Add(firstNumber, secondNumber);
            if (mathType.ToLower() == "subtract")
                result = Subtract(firstNumber, secondNumber);
            if (mathType.ToLower() == "multiply")
                result = Multiply(firstNumber, secondNumber);
            if (mathType.ToLower() == "divide")
                result = Divide(firstNumber, secondNumber);

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }

        //Make sure your methods have XML comments for IntelliSense

        /// <summary>
        /// Adds together two double input values and returns the result.
        /// </summary>
        /// <param name="firstNumber", "secondNumber"></param>
        /// <returns>A double with the addition result</returns> 
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Subtracts the second number from the first number when two double input values are given
        /// and returns the result.
        /// </summary>
        /// <param name="firstNumber", "secondNumber"></param>
        /// <returns>A double with the subtraction result</returns> 
        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Multiplies two double input values and returns the result.
        /// </summary>
        /// <param name="firstNumber", "secondNumber"></param>
        /// <returns>A double with the multiplication result</returns> 
        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Divides the first number by the second number when two double input values are given
        /// and returns the result.
        /// </summary>
        /// <param name="firstNumber", "secondNumber"></param>
        /// <returns>A double with the division result</returns> 
        public static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
