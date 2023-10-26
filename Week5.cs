using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week5
    {
        // Write a method that takes two numbers and an operation (+,-,*,x,/) as input,
        // performs the operation on the numbers and displays the result of the operation.
        public static void Exercise4()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an operator: ");
            char sign = Convert.ToChar(Console.ReadLine());
            

            // switch

            switch (sign)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;
                
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;
                
                case '*':
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / Convert.ToDouble(num2)));
                    break;

                default: Console.WriteLine("Invalid input");
                    break;
            }
        }

        // Write a program to break an integer into a sequence of individual digits.
        public static void Exercise5()
        {
            Console.Write("Enter six non-negative digits: ");
            
            string numbers = Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(" ");

        }

        // Write a program that finds the biggest of three integers, using nested if statements
        public static void Exercise6()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            

            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("{0} is the biggest of the 3 integers.", num3);
                } else { 
                    Console.WriteLine("{0} is the biggest of the 3 integers.", num2);
                }
            } else {
                if (num1 < num3)
                {
                    Console.WriteLine("{0} is the biggest of the 3 integers.", num3);
                } else {
                    Console.WriteLine("{0} is the biggest of the 3 integers.", num1);
                }
            }
        }

        // Sort 3 real numbers in descending order. Use nested if statements.
        public static void Exercise7()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {

                if (num2 < num3)
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
                else
                {

                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
            }
            else
            {
                if (num1 < num3)
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }

        }

        // Write a program that asks for a digit (0-9),
        // and depending on the input, shows the digit as a word (in English).
        // Use a switch statement.

        public static void Exercise8()
        {
            Console.Write("Enter a digit from 0-9: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine("{0} is letter {1}", digit, 'A');
                    break;
                case 1: Console.WriteLine("{0} is letter {1}", digit, 'B');
                    break;
                case 2: Console.WriteLine("{0} is letter {1}", digit, 'C');
                    break;
                case 3: Console.WriteLine("{0} is letter {1}", digit, 'D');
                    break;
                case 4: Console.WriteLine("{0} is letter {1}", digit, 'E');
                    break;
                case 5: Console.WriteLine("{0} is letter {1}", digit, 'F');
                    break;
                case 6: Console.WriteLine("{0} is letter {1}", digit, 'G');
                    break;
                case 7: Console.WriteLine("{0} is letter {1}", digit, 'H');
                    break;
                case 8: Console.WriteLine("{0} is letter {1}", digit, 'I');
                    break;
                case 9: Console.WriteLine("{0} is letter {1}", digit, 'J');
                    break;
                default: Console.WriteLine("Wrong input");
                    break;
            }
        }

        // Write a program that gets the coefficients a, b and c of a quadratic equation: ax*x  + bx + c,
        // calculates and prints its real roots (if they exist),
        // or it prints there are no roots.
        // Quadratic equations may have 0, 1 or 2 real roots.

        public static void Exercise9()
        {
            Console.Write("Enter value a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value c: ");
            double c = Convert.ToDouble(Console.ReadLine());


        }

        // Write a program that finds the greatest of given 5 numbers.

        public static void Exercise10()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5) {
                Console.WriteLine("{0} is the greatest of the given 5 numbers", num1);        
            } else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5) {
                Console.WriteLine("{0} is the greatest of the given 5 numbers", num2);

            } else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine("{0} is the greatest of the given 5 numbers", num3);
            } else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                Console.WriteLine("{0} is the greatest of the given 5 numbers", num4);
            } else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            {
                Console.WriteLine("{0} is the greatest of the given 5 numbers", num5);
            }
        }

        // Write a program that, depending on the user’s choice, inputs int, double or string variable.
        // If the variable is int or double, the program increases it by 1.
        // If the variable is a string, the program appends "*" at the end.
        // Print the result at the console. 

        public static void Exercise11()
        {
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Enter an integer: ");
                    int inputInteger = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(inputInteger + 1);
                    break;

                case 2: Console.Write("Enter a double: ");
                    double inputDouble = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(inputDouble + 1);
                    break;

                case 3: Console.Write("Enter a string: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + '*');
                    break;

                default: Console.WriteLine("Wrong input");
                    break;
            }
        }

        // Write a method that takes userid and password as input (type string).
        // After 3 wrong attempts, user will be rejected.
        // Method must print appropriate message for success and for running out of tries.
        // Hint: You need an if statement that checks the two inputs against set values
        // (For example userId = “mo”, password = “secret” – the inputs are compared to “mo”, and “secret”).
        // Also, you need to have a counter to record number of attempts.
        // You need a while loop to make sure up to 3 attempts are allowed.

        public static void Exercise13()
        {   

            int attempts = 0;

            while (attempts < 3)
            {
                // ask for userID
                Console.Write("Enter your userID: ");
                string userID = Console.ReadLine();

                // ask for password
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                // check if both userID and password is correct
                if (userID.Equals("chimaihueze") && password.Equals("1234")) {

                    Console.WriteLine("Login Successful");
                    break;
                } else
                {
                    // increase number of attempts everytime there's an attempt
                    attempts++;

                    if (attempts == 3)
                    {
                        Console.WriteLine("You have exceeded the number of login attempts");
                        break;
                    }
                    Console.WriteLine("Wrong userID/password! Try again."); 
                }
            }
        }

        // Write a method to print certain values of the function x = y2 + 2y + 1
        // using integer numbers for y, ranging from -5 to +5.

        public static void Exercise14 ()
        {
            while (true) {

                Console.Write("Enter the value of y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (y >= -5 && y <= 5)
                {
                    int x = (int)Math.Pow(y, 2) + (2 * y) + 1;
                    Console.WriteLine(x);
                    break;
                }
                else
                {
                    Console.WriteLine("y should range from -5 to +5");
                }
            }
        }

        // Write a method to print the integer numbers from 1 to 100 counting two by two.

        public static void Exercise15()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        // Write a method to print the multiples of 3 from 1 to 100.

        public static void Exercise16()
        {
            Console.WriteLine("The multiples of 3 include:");
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Write a method to print series, for example: 5, 10, 15, 20, 25, 30…
        // The method must read on the keyboard the number of terms of the series, 1st term, and the increment.

        public static void Exercise17()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Write a method that reads two integer numbers on the keyboard and prints the largest of them.

        public static void Exercise18()
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("{0} is larger than {1}.", num2, num1);
            } else
            {
                Console.WriteLine("{0} is larger than {1}.", num1, num2);
            }
        }

        // Write a method that reads two integer numbers on the keyboard
        // and prints if the first of them is divisible by the second one. 

        public static void Exercise19()
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("{0} is divisble by {1}", num1, num2);
            } else
            {
                Console.WriteLine("{0} is not divisble by {1}", num1, num2);
            }
        }

        // Write a program that applies bonus points to given scores in the range [1…9].
        // Takes as input a score, applies bonus to score and prints the new score.
        //These rules apply: 
            //- If the score is between 1 and 3, the program multiplies it by 10. 
            //- If the score is between 4 and 6, the program multiplies it by 100. 
            //- If the score is between 7 and 9, the program multiplies it by 1000. 
            //- If the score is 0 or more than 9, the program prints an error message.

        public static void Exercise20()
        {
            Console.Write("Enter a score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score > 1 && score < 3)
            {
                Console.WriteLine(score * 10);
            } 

            else if (score > 4 && score < 6)
            {
                Console.WriteLine(score * 100);
            }

            else if (score > 7 && score < 9)
            {
                Console.WriteLine(score * 1000);
            }

            else if (score == 0 || score > 9)
            {
                Console.WriteLine("Wrong input!");
            } else
            {
                Console.WriteLine("Number out of scope");
            }
        }

        // Write a method that reads an integer value on the keyboard
        // and prints if it is an even or an odd number. 

        public static void Exercise23()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number % 2) == 0) { 
                Console.WriteLine("{0} is even.", number); 
            } else
            {
                Console.WriteLine("{0} is odd.", number);
            }
        }

        // Write a method that prints on the screen the price of a cinema ticket according to the age of the customer.
        // The method must read the user’s age and calculate the price as follows:
        // (a) Normal ticket: £7;
        // (b) Children under 5: 60% discount;
        // (c) People over 60: 55% discount. 

        public static void Exercise24()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 5 && age < 60)
            {
                Console.WriteLine("Your ticket price is £7.");
            } else if (age <= 5)
            {
                Console.WriteLine("Your ticket price is £{0}.", (7 * 0.6));
            } else
            {
                Console.WriteLine("Your ticket price is £{0}.", (7 * 0.55));
            }
        }

        // Write a method that reads five integer values on the keyboard and shows the smallest of them.

        public static void Exercise25()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
            {
                Console.WriteLine("{0} is the smallest of the given 5 numbers", num1);
            }
            else if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
            {
                Console.WriteLine("{0} is the smallest of the given 5 numbers", num2);

            }
            else if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
            {
                Console.WriteLine("{0} is the smallest of the given 5 numbers", num3);
            }
            else if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
            {
                Console.WriteLine("{0} is the smallest of the given 5 numbers", num4);
            }
            else if (num5 < num1 && num5 < num2 && num5 < num3 && num5 < num4)
            {
                Console.WriteLine("{0} is the smallest of the given 5 numbers", num5);
            }
        }

        // Write a method that reads three integer values on the keyboard and prints them in decreasing order. 
        public static void Exercise26()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {

                if (num2 < num3)
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
                else
                {

                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
            }
            else
            {
                if (num1 < num3)
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine("Descending order: ");
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }

        }
    }
}
