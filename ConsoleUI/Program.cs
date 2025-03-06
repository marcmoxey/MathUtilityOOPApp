using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathTools;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
          

                double x = RequestData.GetADouble("Please enter your first number: ");
                double y = RequestData.GetADouble("Please enter your second number: ");

                Console.WriteLine();
                Console.WriteLine("Choose an operation you would like to do");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit program");

                string userInput;
                userInput = Console.ReadLine();


                switch (userInput)
                {

                    case "1":
                        double results = MathUtility.Add(x, y);
                        UserMessages.PrintResultMessage($"The result of adding {x} and {y} is {results}");
                        break;
                    case "2":
                        results = MathUtility.Subtract(x, y);
                        UserMessages.PrintResultMessage($"The result of subtracting {x} and {y} is {results}");
                        break;
                    case "3":
                        results = MathUtility.Multiply(x, y);
                        UserMessages.PrintResultMessage($"The result of multiplying {x} and {y} is {results}");
                        break;
                    case "4":
                        results = MathUtility.Divide(x, y);
                        UserMessages.PrintResultMessage($"The results of dividing {x} and {y} is {results}");
                        break;
                    case "5":
                        break;

                } 


         








            Console.ReadLine();
        }
    }
}
