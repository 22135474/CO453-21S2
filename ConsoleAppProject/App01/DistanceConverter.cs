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
            Console.WriteLine("4. Kelometer");
            Console.WriteLine("5. Millimeter");
            Console.WriteLine("6. Inch");
        }

        private string SelectUnit(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            OutputChoices();
            Console.Write("\n > ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": return "FEET";
                case "2": return "MILES";
                case "3": return "METRES";
                case "4": return "KELOMETER";
                case "5": return "MILLIMETER";
                case "6": return "INCH";
                default: throw new InvalidOperationException("Please enter valid input.");
            }
        }

        private void InputFromDistance()
        {
            try
            {
                Console.WriteLine("Please enter the number of " + fromUnit);
                fromDistance = Convert.ToDouble(Console.ReadLine());
                if (fromDistance < 0)
                    throw new InvalidOperationException("Can not input negitive number.");
            }
            catch
            {
                throw new InvalidOperationException("Invalid input - only input numbers.");
            }
        }

        private void ConvertDistance()
        {
            //FEET conversion
            if (fromUnit == "FEET" && toUnit == "MILES")
            {
                toDistance = fromDistance / FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "METRES")
            {
                toDistance = fromDistance / 3.28084;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance * 0.000305;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 304.8;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "INCH")
            {
                toDistance = fromDistance / 12
;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "FEET")
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //MILES conversion
            if (fromUnit == "MILES" && toUnit == "FEET")
            {
                toDistance = fromDistance * FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "METRES")
            {
                toDistance = fromDistance * METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance / 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 1609350;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "INCH")
            {
                toDistance = fromDistance / 63360
;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "MILES")
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //METRES conversion
            if (fromUnit == "METRES" && toUnit == "FEET")
            {
                toDistance = fromDistance / 0.3048;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "MILES")
            {
                toDistance = fromDistance / METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance / 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "INCH")
            {
                toDistance = fromDistance / 39.37
;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "METRES")
            {
                toDistance = fromDistance - METRES_IN_MILES + METRES_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //KELOMETER conversion
            if (fromUnit == "KELOMETER" && toUnit == "FEET")
            {
                toDistance = fromDistance / 0.000305;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "MILES")
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "METRES")
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 1000000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "INCH")
            {
                toDistance = fromDistance / 39370.1;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance * 1;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //MILLIMETER conversion
            if (fromUnit == "MILLIMETER" && toUnit == "FEET")
            {
                toDistance = fromDistance * 0.0032808399;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "MILES")
            {
                toDistance = fromDistance / 1609344;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "METERS")
            {
                toDistance = fromDistance * 0.001;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance / 100000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "INCH")
            {
                toDistance = fromDistance / 25.4;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 1;  
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //INCH conversion
            if (fromUnit == "INCH" && toUnit == "FEET")
            {
                toDistance = fromDistance * 0.0833333;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "MILES")
            {
                toDistance = fromDistance * 63360;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "METRES")
            {
                toDistance = fromDistance * 0.0254;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "KELOMETER")
            {
                toDistance = fromDistance * 39370.1;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "MILLIMETER")
            {
                toDistance = fromDistance * 25.4;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "INCH")
            {
                toDistance = fromDistance * 1;
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
