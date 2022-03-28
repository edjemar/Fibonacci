using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursive
{
    internal class Fibonacci_Recursive
    {
        static void Main(string[] args)
        {
            //Ingrese la longitud de la serie de Fibonacci
            Console.Write("Ingrese la longitud de la serie de Fibonacci \n");
            Console.Write("Please enter the Length of the Fibonacci Series : ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);
            Console.ReadKey();
        }
        public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            //Console.Write(firstNumber + " ");
            Console.Write(secondNumber + " ");
            if (counter < number)
            {
                //FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);

            }
        }
    }
}
