using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Convert distances based on user imputs 
    /// Feet, Miles, metres, Kelometers, Millimeters and inches
    /// </summary>
    /// <author>
    /// Stefan version 0.1
    /// </author>

    /// <summary>
    ///
    /// </summary>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1689.34;

        private string toUnit;
        private string fromUnit;
        private double toDistance;
        private double fromDistance;

        /// <summary>
        ///
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = SelectUnit("Please choose a unit to convert FROM");
            toUnit = SelectUnit("Please choose a unit to convert TO");
            InputFromDistance();
            ConvertDistance();
            PrintResult();
        }

        /// <summary>
        ///
        /// </summary>
        private void OutputChoices()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Metres");
            Console.WriteLine("4. Kelometer");
            Console.WriteLine("5. Millimeter");
            Console.WriteLine("6. Inch");
        }
        
        /// <summary>
        ///
        /// </summary>
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

        /// <summary>
        ///
        /// </summary>
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

        /// <summary>
        ///
        /// </summary>
        private void ConvertDistance()
        {
            //FEET conversion
            if (fromUnit == "FEET" && toUnit == "MILES") //Feet to miles
            {
                toDistance = fromDistance / FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "METRES") //Feet to metres
            {
                toDistance = fromDistance / 3.28084;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "KELOMETER") //Feet to kelometers
            {
                toDistance = fromDistance * 0.000305;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "MILLIMETER") //Feet to Millimeters
            {
                toDistance = fromDistance * 304.8;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "INCH") //feet to inches
            {
                toDistance = fromDistance / 12;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "FEET" && toUnit == "FEET") // Feet to feet 
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //MILES conversion
            if (fromUnit == "MILES" && toUnit == "FEET") //Miles to feet
            {
                toDistance = fromDistance * FEET_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "METRES") //Miles to metres
            {
                toDistance = fromDistance * METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "KELOMETER") //Miles to kelometers
            {
                toDistance = fromDistance / 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "MILLIMETER") //Miles to Millimeters
            {
                toDistance = fromDistance * 1609350;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "INCH") //Miles to inches
            {
                toDistance = fromDistance / 63360;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILES" && toUnit == "MILES") //Miles to miles 
            {
                toDistance = fromDistance - FEET_IN_MILES + FEET_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //METRES conversion
            if (fromUnit == "METRES" && toUnit == "FEET") //Metres to feet 
            {
                toDistance = fromDistance / 0.3048;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "MILES") //metres to miles 
            {
                toDistance = fromDistance / METRES_IN_MILES;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "KELOMETER") //Metres to kelometers 
            {
                toDistance = fromDistance / 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "MILLIMETER") //Metres to millimeters 
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "INCH") //Metres to inches 
            {
                toDistance = fromDistance / 39.37;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "METRES" && toUnit == "METRES") //Metres to metres 
            {
                toDistance = fromDistance - METRES_IN_MILES + METRES_IN_MILES;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //KELOMETER conversion
            if (fromUnit == "KELOMETER" && toUnit == "FEET") //Kelometer to feet 
            {
                toDistance = fromDistance / 0.000305;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "MILES") //kKelometer to miles 
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "METRES") //Kelometer to metres 
            {
                toDistance = fromDistance * 1000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "MILLIMETER") //Kelometer to millimeters 
            {
                toDistance = fromDistance * 1000000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "INCH") //Kelometer to inches 
            {
                toDistance = fromDistance / 39370.1;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "KELOMETER" && toUnit == "KELOMETER") // kelometer to kelometers 
            {
                toDistance = fromDistance * 1;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //MILLIMETER conversion
            if (fromUnit == "MILLIMETER" && toUnit == "FEET") //Millimeters to feet 
            {
                toDistance = fromDistance * 0.0032808399;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "MILES") //Millimeters to miles 
            {
                toDistance = fromDistance / 1609344;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "METERS") //Millimeter to meters 
            {
                toDistance = fromDistance * 0.001;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "KELOMETER") //Millimeter to kelometers 
            {
                toDistance = fromDistance / 100000;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "INCH") //Millimeters to inches 
            {
                toDistance = fromDistance / 25.4;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "MILLIMETER" && toUnit == "MILLIMETER") //Millimeter to millimeter 
            {
                toDistance = fromDistance * 1;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
            //INCH conversion
            if (fromUnit == "INCH" && toUnit == "FEET") //Inch to feet 
            {
                toDistance = fromDistance * 0.0833333;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "MILES") //Inch to miles 
            {
                toDistance = fromDistance * 63360;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "METRES") //Inch to metres 
            {
                toDistance = fromDistance * 0.0254;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "KELOMETER") //Inch to kelometers 
            {
                toDistance = fromDistance * 39370.1;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "MILLIMETER") //Inch to millimeters 
            {
                toDistance = fromDistance * 25.4;
                Console.WriteLine("Calculation successful");
            }
            if (fromUnit == "INCH" && toUnit == "INCH") //Inch to inch 
            {
                toDistance = fromDistance * 1;
                Console.WriteLine("Well this is a pointless calculation isn't it...");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void PrintResult()
        {
            Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance + " " + toUnit);
        }
    }
}
