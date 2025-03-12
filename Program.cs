using System;

namespace MySpace
{
    class MyClass
    {
        static double add(double num1, double num2)
        {
            double result = num1;
            result += num2;
            return result;
        }

        static double subtract(double num1, double num2)
        {
            double result = num1;
            result -= num2;
            return result;
        }

        static double multiply(double num1, double num2)
        {
            double result = num1;
            result *= num2;
            return result;
        }

        static double divide(double num1, double num2)
        {
            double result = num1;
            result /= num2;
            return result;
        }

        public static void Main(string[] args)
        {
            double new_operation = 1;

            double num1;

            while (new_operation == 1)
            {
                Console.WriteLine("Num 1 : ");

                num1 = Convert.ToDouble(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("\nOperation\n===========================================\n1. +\n2. -\n3. *\n4. /\n0. break\n");
                    double operation = Convert.ToDouble(Console.ReadLine());

                    if (operation == 0)
                    {
                        break;
                    }

                    Console.WriteLine("\n\nNum : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());



                    if (operation == 1)
                    {
                        num1 = add(num1, num2);
                        Console.Write("\nOutput : ");
                        Console.Write(num1);
                        Console.WriteLine("\n");
                    }
                    else if (operation == 2)
                    {
                        num1 = subtract(num1, num2);
                        Console.Write("\nOutput : ");
                        Console.Write(num1);
                        Console.WriteLine("\n");
                    }
                    else if (operation == 3)
                    {
                        num1 = multiply(num1, num2);
                        Console.Write("\nOutput : ");
                        Console.Write(num1);
                        Console.WriteLine("\n");
                    }
                    else if (operation == 4)
                    {
                        num1 = divide(num1, num2);
                        Console.Write("\nOutput : ");
                        Console.Write(num1);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation. Try again with number 1~4. ");
                    }
                }

                Console.Write("\n\n\n\nOutput : ");
                Console.Write(num1);
                Console.WriteLine("\n");

                Console.WriteLine("\nEnd Operation. \n\n\n");

                Console.WriteLine("New Operation ? ( 1 for yes; 0 for no. ) ");
                new_operation = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n\n\n\n==============================================\nEnd of process \n==============================================\n");
        }
    }
}