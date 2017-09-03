using System;

namespace problem2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number to hold value with decimal
            //var input - Console.ReadLine();
            //var number input - converting string to double
            //checks if statement is true - (entered a number smaller than 100 or 100)
            //calculates times tables
            //outputs back to user

           //Start the program with Clear();
           Console.Clear();
           Console.WriteLine("This program will display division tables of inputed number that is less than 100");
           Console.WriteLine("");
           Console.WriteLine("Please enter a number less than 100");

            double number = 0;
            var input = Console.ReadLine();

            var numberinput = double.TryParse(input, out number);

            if (number < 100)
            {
                for (var i = 0; i < 12; i++)
                    {
                    var a = i + 1;
                    Console.WriteLine($"{number} / {a} = {number / a}");
                    }
            }
            else 
            {
                Console.WriteLine("You didn't enter a number less than 100");
                Console.ReadLine();
            }
           
           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();

        }
    }
}
