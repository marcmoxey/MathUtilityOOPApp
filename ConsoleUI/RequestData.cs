﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble  = double.TryParse(numberText, out output);

            while (isDouble == false) 
            {
                Console.WriteLine("That was not a valid number. Please try again");
                Console.WriteLine(message);
                numberText = Console.ReadLine();    
            
            }

            return output;
        }
    }
}
