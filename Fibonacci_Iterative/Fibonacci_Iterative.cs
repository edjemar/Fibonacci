using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Iterative
{
    internal class Fibonacci_Iterative
    {
        public static void Main()
        {
            //int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            int firstNumber = 1, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Introduzca el número de elementos a Imprimir \n");
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            Console.ReadKey();
        }
    }
}
