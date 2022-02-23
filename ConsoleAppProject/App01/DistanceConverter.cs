using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Stefan version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1689.34;

        private string toUnit;
        private string fromUnit;
        private double toDistance;
        private double fromDistance;

        public int Metres { get; }

        public DistanceConverter()
        {
            fromUnit = SelectUnit("Please choose a unit to convert FROM");
            toUnit = SelectUnit("Please choose a unit to convert TO");
            InputFromDistance();
            ConvertDistance();
            PrintResult();
        }

        private void OutputChoices()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Metres");
        }

        private string SelectUnit(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            OutputChoices();
            Console.Write("\n > ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": return "FEET"; break;
                case "2": return "MILES"; break;
                case "3": return "METRES"; break;
            }
            return input.ToUpper();
        }

        private void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + fromUnit);
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }

        private void ConvertDistance()
        {
            if(fromUnit == "MILES" && toUnit == "FEET")
            {
                toDistance = fromDistance * FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "MILES")
            {
                toDistance = fromDistance / FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "METRES")
            {
                toDistance = fromDistance * METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "MILES")
            {
                toDistance = fromDistance / METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "FEET")
            {
                toDistance = fromDistance / 0.3048;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "METRES")
            {
                toDistance = fromDistance / 3.28084;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "FEET")
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            if (fromUnit == "MILES" && toUnit == "MILES")
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            if (fromUnit == "METRES" && toUnit == "METRES")
            {
                toDistance = fromDistance - METRES_IN_MILES + METRES_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
        }

        private void PrintResult()
        {
            Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance + " " + toUnit);
        }

        private void OutputHeading()
        { 
            Console.WriteLine(" =================================================");
            Console.WriteLine("    App 01 DistanceConverter ");
            Console.WriteLine("        by Stefan Allen                           ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
    }
}
