using System;

namespace Blueshift01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title
            Console.WriteLine("Blueshift Problem 01 in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
               
                // Ask the user to choose an option.
                Console.WriteLine("Choose a calculation option from the following list:");
                Console.WriteLine("\ta - Print a copy of the number");
                Console.WriteLine("\tb - Calculate the factorial of the number");
                Console.WriteLine("\tc - Check the number whether Odd or Even");
                
                Console.Write("What is your option code (a or b or c ) ? ");

                
                // Use a switch statement to do the math.
                switch (Console.ReadLine())
                {
                    case "a":

                            // calculation 01 - copy
                            int x;
                            Console.WriteLine("Enter a number : ");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Your result is : " + x  );
                            break;
                    case "b":
                        {
                            // calculation 02 - factorial
                            int i, f = 1, y;
                            Console.Write("Enter a number to calculate the factorial of a given number :\n");
                            y = Convert.ToInt32(Console.ReadLine());
                            for (i = 1; i <= y; i++)
                                f = f * i;

                            Console.Write("The Factorial of {0} is: {1}\n", y, f);
                        }break;
                    case "c":
                        {   // calculation 03 - odd or even
                            int z, rem1;
                            Console.Write("Input an integer to check whether a number is even or odd :\n");
                            z = Convert.ToInt32(Console.ReadLine());
                            rem1 = z % 2;
                            if (rem1 == 0)
                                Console.WriteLine("{0} is an even integer.\n", z);
                            else
                                Console.WriteLine("{0} is an odd integer.\n", z);
                        }break;

                }
                // Wait for the user to respond before closing.
                Console.Write("Press 'Exit' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine().ToLower().Equals("exit"))
                    endApp = true;
                
               
                Console.WriteLine("\n"); // Friendly linespacing.

            }return;
                
        }
    }
}
