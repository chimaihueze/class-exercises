using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercises
{
	internal class Week6
	{
		// Exercise 1
		public static void Exercise1()
		{
			Console.Write("Enter a number: ");
			string numbers = Console.ReadLine();

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
		}

		// Exercise1 2.0
		public static void Exercise1x()
		{
			int digit = 0;

			Console.Write("Enter a number: ");
			int num = Convert.ToInt32(Console.ReadLine());
			int originalNum = num;
			while (num > 0)
			{
				num = num / 10;

				digit++;
			}


			num = originalNum;
			int divider = 1;

			for (int i = 1; i < digit; i++)
			{
				divider = divider * 10;
			}


			int digitIndex = 0;
			for (int i = 0; i < digit; i++)
			{
				digitIndex = num / divider;
				Console.Write(digitIndex + " ");
				num %= divider;
				//Console.WriteLine(num);
				divider /= 10;
			}
		}


		//Exercise 2a
		public static void Exercise2a()
		{
			Console.Write("Enter first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			if (number1 == number2)
			{
				Console.WriteLine("{0} is equal to {1}", number1, number2);
			}
			else
			{
				Console.WriteLine("{0} is not equal to {1}", number1, number2);
			}
		}


		// Exercise 2b

		public static void Exercise2b()
		{
			Console.Write("Enter any character, or q to quit: ");
			char input = Convert.ToChar(Console.ReadLine());

			while (input != 'q' && input != 'Q')
			{
				Exercise2a();

				Console.Write("Enter any character, or q to quit: ");
				input = Convert.ToChar(Console.ReadLine());
			}
		}

		// Exercise 3

		// Write a program to create an array of integer values,
		// assigns to each position of the array the position value plus 1, and prints the array.
		// The number of elements of the array must be read on the keyboard.
		// Introduce a while loop for the program to keep working input is ‘q’.

		public static void Exercise3()
		{

			Console.Write("Enter size of array: ");
			int size = Convert.ToInt32(Console.ReadLine());
		   
				int[] intArray;
				intArray = new int[size];

				for (int i = 0; i < intArray.Length; i++)
				{
					intArray[i] = i + 1;
				}

				Console.Write("The array is: ");

				for (int i = 0; i < size; i++)
				{
					Console.Write(intArray[i] + " ");
				}
			Console.WriteLine("");
		}

		public static void Exercise3a()
		{

			Console.Write("Enter any character or q to quit: ");
			char input = Convert.ToChar(Console.ReadLine());

			while (input != 'q' && input != 'Q')
			{
				Exercise3();

				Console.Write("Enter any character of q to quit: ");
				input = Convert.ToChar(Console.ReadLine());
			}
		}

		// Write a program that for a given size of array,
		// creates and fills the array a with random integers in the range 1 to 100
		// and prints it out (for testing purposes). 
		// Hint: ‘Random random = new Random();’ creates ‘random’ object of Type ‘Random’.
		// ‘random.Next(1, 100)’ generates an integer of value between 1 and 100.


		// Extend the program to after creating such a random array, do each of the following:
		// Calculate the sum of the elements of A and print it out.
		// Count the number of elements in A whose contents are less than 10.
		// Create a new array b of the same size such that for all B[i] (0<=i<size), B[i] = A[i] + A[i + 1].
		// Hint: Make sure you do not overflow when you get to size.


		public static void Exercise4()
		{

			Console.Write("Enter size of array: ");
			int size = Convert.ToInt32(Console.ReadLine());

			int[] intArray = new int[size];
			Random randomNumber = new Random();
			int sum = 0;
			int lessThan10 = 0;

			int[] intArrayB = new int[size];

			Console.Write("ArrayA: ");

			for (int i = 0; i < intArray.Length; i++)
			{
				
				intArray[i] = randomNumber.Next(1, 100);
				

				sum += intArray[i];
				if (intArray[i] < 10)
				{
					lessThan10++;
				}
				Console.Write(intArray[i] + " ");
				
			}

			// Array B
			Console.Write("\nArrayB: ");
			for (int i = 0; i < size; i++)
			{
				if (i != size)
				{
					intArrayB[i] = intArray[i] + intArray[i]+1;
					Console.Write(intArrayB[i] + " ");
				}
				
			}

			Console.WriteLine("\nSum of array: {0}", sum);
			Console.WriteLine("Number of elements less than 10: {0}", lessThan10);
		}

		//Write a program that fills an array with 20 random integers, prints out the array. Test it.
		//Extend the program to ask for an integer,
		//then it would search the array to discover whether it contains the integer.
		//Extend the program to scan the array from one end to the other to find the largest element.
		//Print out both the maximum in the array and the index (position) at which it is found.
		//HINT: Keep a record of the largest value found so far and compare it with subsequent values.

		public static void Exercise5()
		{
			int[] intArray = new int[20];

			Random randomNumber = new Random();

			for (int i = 0; i < intArray.Length; i++)
			{
				intArray[i] = randomNumber.Next(1, 50);
				Console.Write(intArray[i] + " ");
			}

			Console.Write("\nEnter a number to search: ");
			int number = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < intArray.Length; i++)
			{
				if (intArray[i] == number)
				{
					Console.WriteLine("The array contains: " + number);
					break;
				} else if (i == intArray.Length - 1) 
				{
                    Console.WriteLine("The array doesn't contain: " + number);
                }
            }

			// finding the largest

			int largestNumber = 0;
			int position = 0;
			for (int i = 0; i < intArray.Length; i++)
			{
				if (intArray[i] > largestNumber)
				{
					largestNumber = intArray[i];
					position = i;
				}
			}
            Console.WriteLine("Largest number: {0}. Position: {1}", largestNumber, position+1);
        }
	}
}
