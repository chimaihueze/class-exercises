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

        //Write a program that fills an array of given size with random integers, prints out the array. Test it.
        //Extend the program to double the size of the array,
        //keep the same random integers in indexes 0 to size-1,
        //and fill in the rest with new random integers.
        //Hint: Arrays are immutable, you can’t change the size of arrays,
        //how would you overcome/implement?

        public static void Exercise2()
        {
            int[] intArray = new int[5];

            Random random = new Random();

            Console.Write("Array: ");

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1, 20);

                Console.Write(intArray[i] + " ");

            }
            Console.WriteLine();

            // doubling the size of array

            Array.Resize(ref intArray, intArray.Length * 2);

            for (int i = intArray.Length / 2; i < intArray.Length; i++)
            {
                
                    intArray[i] = random.Next(1, 20);
                    Console.WriteLine(intArray[i] + " ");
            }

            foreach (int number in intArray)
            {
                Console.Write(number + " ");
            }
        }

        // Write a program that creates and fills in an array with all the letters of alphabet.
        // It takes a string input, it prints a string of numbers separated by space,
        // each number is the index in array of the corresponding letter in array.
        // For example: It reads “cbad” and it prints “2 1 0 3”. 

        public static void Exercise3()
        {
            char[] alphabet = new char[26];
            Console.Write("Alphabets: ");
            for (int i = 0;i < alphabet.Length;i++)
            {
                alphabet[i] = (char)('a' + i);
                Console.Write(alphabet[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (alphabet[i] == input[j])
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

    }
}
