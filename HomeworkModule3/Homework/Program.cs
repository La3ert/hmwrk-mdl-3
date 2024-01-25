using System.Numerics;

namespace Homework
{
    class Program
    {
        static void Main(string[] args) 
        { 
            //Finding the maximum
            Console.WriteLine("Enter first integer");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second integer");
            int secondNumber = int.Parse(Console.ReadLine());
            
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Max value {firstNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Max value {secondNumber}");
            }
            else
            {
                Console.WriteLine("Values are equivalent");
            }   
            
            //Fibonacci numbers
            Console.WriteLine("Enter the number of Fibonacci numbers");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("Enter a number greater than 1");
                n = int.Parse(Console.ReadLine());
            }
            int[] fibonacciNumbers = new int[n];

            int num = 1;
            int num1 = 1;
            int num2 = 2;
            
            Console.Write(num + " ");
            fibonacciNumbers[0] = num1;
            
            for (int i = 1; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = num1;
                Console.Write(num1 + " ");
                num = num2;
                num2 += num1;
                num1 = num;
            }

            Console.WriteLine();
            
            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.Write(fibonacciNumbers[i] + " ");
            }
            
            //Calculating the average
            Console.WriteLine("Enter a positive number. If you want to stop entering numbers, enter 0");
            int[] positiveNumber = new int[10];
            int amountOfNumbers = 0;
            int b = int.MaxValue;
            while (amountOfNumbers < 10 && b != 0)
            {
                Console.WriteLine("Enter a positive number. If you want to stop entering numbers, enter 0");
                positiveNumber[amountOfNumbers] = int.Parse(Console.ReadLine());
                b = positiveNumber[amountOfNumbers];
                amountOfNumbers++;
            }
            
            int sum = 0;
            int count = 0;
            foreach (var cur in positiveNumber)
            {
                if (cur > 0 && cur % 3 == 0)
                {
                    sum += cur;
                    count++;
                }
            }

            double average = sum / count;
            Console.WriteLine(average);
            
            //Factorial calculation
            Console.WriteLine("Enter an integer greater than 0");
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            
            //Three authentication attempts
            Console.WriteLine("Enter login and password in this format \"login\\password\"");
            string loginPassword = @"johnsilver\qwerty";
            string enteredLoginPassword = Console.ReadLine();
            int attempts = 1;
            while (loginPassword != enteredLoginPassword && attempts != 3)
            {
                Console.WriteLine(@$"Error! You entered an incorrect login\password. You have {3-attempts} attempts left");
                enteredLoginPassword = Console.ReadLine();
                attempts++;
            }

            if (enteredLoginPassword == loginPassword)
            {
                Console.WriteLine("Enter the System");
            }
            else
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }
        }
    }
}