using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week7a
    {
        //Write a program to initialize a two-dimensional array with random ‘integer’ values between 0 and 10.
        //The size of the array (The same number of rows and columns) must be read from the keyboard.
        //Extend the program to calculate:
            //The maximum value in the array,
            //the minimum value in the array ,
            //the sum of the elements in the diagonal (i.e., elements at positions (0, 0), (1, 1), etc.).
        public static void Exercise1()
        {
            Console.Write("Enter the number of rows: ");    
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] intArray = new int[row, column];
            Random random = new Random();

            int maximumValue = 0;
            

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = random.Next(1, 10);

                    if (intArray[i, j] > maximumValue)
                    {
                        maximumValue = intArray[i, j];
                    }

                    Console.Write(intArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            int minimumValue = maximumValue;

            // finding the minimum value
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] < minimumValue)
                    {
                        minimumValue = intArray[i, j];
                    }
                }
            }

            // sum of diagonal
            int sum = 0;
            //int additive = 0;
            for (int i = 0; i < intArray.GetLength(0); i++)
            {

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += intArray[i, j];

                    }


                }
            }

            Console.WriteLine("Maximum value: " + maximumValue);
            Console.WriteLine("Minimum value: " + minimumValue);
            Console.WriteLine("Sum: " + sum);

        }

       

    }
}
