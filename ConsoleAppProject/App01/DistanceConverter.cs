using System;
using System.Runtime;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// distance cover that converts a chosen unit given by user to their preferred unit
    /// </summary>
    /// <author>
    /// Nick Day version 0.2 - 05/02/21
    /// </author>

    /// <summary>
    /// Value for maths calculations for each measurement
    /// </summary>
    public class DistanceConverter
    {
        public const int FEET_IN_FEET = 1;
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METERS = 0.3048;
        public const double FEET_IN_KELOMETER = 0.0003048;
        public const double FEET_IN_MILLIMETER = 304.8;
        public const int FEET_IN_INCH = 12;

        public const int MILES_IN_FEET = 5280;
        public const int MILES_IN_MILES = 1;
        public const double MILES_IN_METERS = 1609.344;
        public const double MILES_IN_KELOMETER = 1.609344;
        public const double MILES_IN_MILLIMETER = 1609344;
        public const int MILES_IN_INCH = 63360;

        public const double METERS_IN_FEET = 3.2808398950131;
        public const double METERS_IN_MILES = 0.00062137119223733;
        public const int METERS_IN_METERS = 1;
        public const double METERS_IN_KELOMETER = 0.001;
        public const int METERS_IN_MILLIMETER = 1000;
        public const double METERS_IN_INCH = 39.370078740157;

        public const double KELOMETER_IN_FEET = 3280.8398950131;
        public const double KELOMETER_IN_MILES = 0.62137119223733;
        public const int KELOMETER_IN_METERS = 1000;
        public const int KELOMETER_IN_KELOMETER = 1;
        public const int KELOMETER_IN_MILLIMETER = 1000000;
        public const double KELOMETER_IN_INCH = 39370.078740157;

        public const double MILLIMETER_IN_FEET = 0.0032808398950131;
        public const int MILLIMETER_IN_MILES = 1609344;
        public const double MILLIMETER_IN_METERS = 0.001;
        public const int MILLIMETER_IN_KELOMETER = 1000000;
        public const int MILLIMETER_IN_MILLIMETER = 1;
        public const double MILLIMETER_IN_INCH = 0.039370078740157;

        public const double INCH_IN_FEET = 0.083333333333333;
        public const int INCH_IN_MILES = 63360;
        public const double INCH_IN_METERS = 0.0254;
        public const double INCH_IN_KELOMETER = 39370.078740157;
        public const double INCH_IN_MILLIMETER = 25.4;
        public const int INCH_IN_INCH = 1;

        public const string FEET = "FEET";
        public const string MILES = "MILES";
        public const string METERS = "METERS";
        public const string KELOMETER = "KELOMETER";
        public const string MILLIMETER = "MILLIMETER";
        public const string INCH = "INCH";

        public string ToUnit { get; set; }
        public string FromUnit { get; set; }
        public double ToDistance { get; set; }
        public double FromDistance { get; set; }

        /// <summary>
        /// For the user to select their input
        /// Telling the user what to input to use the converter
        /// </summary>
        public DistanceConverter()
        {
            /*
            FromUnit = SelectUnit("Please choose a unit to convert FROM: ");
            ToUnit = SelectUnit("Please choose a unit to convert TO: ");
            InputFromDistance();
            ConvertDistance();
            PrintResult();
            */
        }

        /// <summary>
        /// Output for first prompt telling users which measurements are available
        /// </summary>
        private void OutputChoices()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
            Console.WriteLine("4. Kelometer");
            Console.WriteLine("5. Millimeter");
            Console.WriteLine("6. Inch");
        }

        /// <summary>
        /// Output for second prompt telling users which measurements are available
        /// allows the users to beable to select the unit they wish and gives error if needed 
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
                case "3": return "METERS";
                case "4": return "KELOMETER";
                case "5": return "MILLIMETER";
                case "6": return "INCH";
                default: throw new InvalidOperationException("Please enter valid input.");
            }
        }

        /// <summary>
        /// Allow the user to input the number of measurements the require
        /// Also gives error messages for negative and invalid inputs 
        /// </summary>
        private void InputFromDistance()
        {
            try
            {
                Console.WriteLine("Please enter the number of " + FromUnit);
                FromDistance = Convert.ToDouble(Console.ReadLine());
                if (FromDistance < 0)
                    throw new InvalidOperationException("Can not input negitive number.");
            }
            catch
            {
                throw new InvalidOperationException("Invalid input - only input numbers.");
            }
        }

        ///<summary>
        /// This method converts miles to feet
        ///</summary>
        public void ConvertDistance()
        {
            // Convert Feet
            if (FromUnit == "FEET" && ToUnit == "FEET") //FEET TO FEET
            {
                ToDistance = FromDistance * (double)FEET_IN_FEET;
            }
            if (FromUnit == "FEET" && ToUnit == "MILES") //FEET TO MILES
            {
                ToDistance = FromDistance / (double)FEET_IN_MILES;
            }
            if (FromUnit == "FEET" && ToUnit == "METERS") //FEET TO METRES
            {
                ToDistance = FromDistance * (double)FEET_IN_METERS;
            }
            if (FromUnit == "FEET" && ToUnit == "KELOMETER") //FEET TO KELOMETER
            {
                ToDistance = FromDistance * (double)FEET_IN_KELOMETER;
            }
            if (FromUnit == "FEET" && ToUnit == "MILLIMETER") //FEET TO MILLIMETER
            {
                ToDistance = FromDistance * (double)FEET_IN_MILLIMETER;
            }
            if (FromUnit == "FEET" && ToUnit == "INCH") //FEET TO INCH
            {
                ToDistance = FromDistance * (double)FEET_IN_INCH;
            }
            // Convert Miles
            if (FromUnit == "MILES" && ToUnit == "FEET") //MILES TO FEET
            {
                ToDistance = FromDistance * (double)MILES_IN_FEET;
            }
            if (FromUnit == "MILES" && ToUnit == "MILES") //MILES TO MILES
            {
                ToDistance = FromDistance * (double)MILES_IN_MILES;
            }
            if (FromUnit == "MILES" && ToUnit == "METERS") //MILES TO METRES
            {
                ToDistance = FromDistance * (double)MILES_IN_METERS;
            }
            if (FromUnit == "MILES" && ToUnit == "KELOMETER") //MILES TO KELOMETER
            {
                ToDistance = FromDistance * (double)MILES_IN_KELOMETER;
            }
            if (FromUnit == "MILES" && ToUnit == "MILLIMETER") //MILES TO MILLIMETER
            {
                ToDistance = FromDistance * (double)MILES_IN_MILLIMETER;
            }
            if (FromUnit == "MILES" && ToUnit == "INCH") //MILES TO INCH
            {
                ToDistance = FromDistance * (double)MILES_IN_INCH;
            }
            // Convert Meters
            if (FromUnit == "METERS" && ToUnit == "FEET") //METERS TO FEET
            {
                ToDistance = FromDistance * (double)METERS_IN_FEET;
            }
            if (FromUnit == "METERS" && ToUnit == "MILES") //METERS TO MILES
            {
                ToDistance = FromDistance * (double)METERS_IN_MILES;
            }
            if (FromUnit == "METERS" && ToUnit == "METERS") //METERS TO METRES
            {
                ToDistance = FromDistance * (double)METERS_IN_METERS;
            }
            if (FromUnit == "METERS" && ToUnit == "KELOMETER") //METERS TO KELOMETER
            {
                ToDistance = FromDistance * (double)METERS_IN_KELOMETER;
            }
            if (FromUnit == "METERS" && ToUnit == "MILLIMETER") //METERS TO MILLIMETER
            {
                ToDistance = FromDistance * (double)METERS_IN_MILLIMETER;
            }
            if (FromUnit == "METERS" && ToUnit == "INCH") //METERS TO INCH
            {
                ToDistance = FromDistance * (double)METERS_IN_INCH;
            }
            // Convert Kelometer
            if (FromUnit == "KELOMETER" && ToUnit == "FEET") //KELOMETER TO FEET
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_FEET;
            }
            if (FromUnit == "KELOMETER" && ToUnit == "MILES") //KELOMETER TO MILES
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_MILES;
            }
            if (FromUnit == "KELOMETER" && ToUnit == "METERS") //KELOMETER TO METRES
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_METERS;
            }
            if (FromUnit == "KELOMETER" && ToUnit == "KELOMETER") //KELOMETER TO KELOMETER
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_KELOMETER;
            }
            if (FromUnit == "KELOMETER" && ToUnit == "MILLIMETER") //KELOMETER TO MILLIMETER
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_MILLIMETER;
            }
            if (FromUnit == "KELOMETER" && ToUnit == "INCH") //KELOMETER TO INCH
            {
                ToDistance = FromDistance * (double)KELOMETER_IN_INCH;
            }
            // Convert Millimeter
            if (FromUnit == "MILLIMETER" && ToUnit == "FEET") //MILLIMETER TO FEET
            {
                ToDistance = FromDistance * (double)MILLIMETER_IN_FEET;
            }
            if (FromUnit == "MILLIMETER" && ToUnit == "MILES") //MILLIMETER TO MILES
            {
                ToDistance = FromDistance / (double)MILLIMETER_IN_MILES;
            }
            if (FromUnit == "MILLIMETER" && ToUnit == "METERS") //MILLIMETER TO METRES
            {
                ToDistance = FromDistance * (double)MILLIMETER_IN_METERS;
            }
            if (FromUnit == "MILLIMETER" && ToUnit == "KELOMETER") //MILLIMETER TO KELOMETER
            {
                ToDistance = FromDistance / (double)MILLIMETER_IN_KELOMETER;
            }
            if (FromUnit == "MILLIMETER" && ToUnit == "MILLIMETER") //MILLIMETER TO MILLIMETER
            {
                ToDistance = FromDistance * (double)MILLIMETER_IN_MILLIMETER;
            }
            if (FromUnit == "MILLIMETER" && ToUnit == "INCH") //MILLIMETER TO INCH
            {
                ToDistance = FromDistance * (double)MILLIMETER_IN_INCH;
            }
            // Convert Inch
            if (FromUnit == "INCH" && ToUnit == "FEET") //INCH TO FEET
            {
                ToDistance = FromDistance * (double)INCH_IN_FEET;
            }
            if (FromUnit == "INCH" && ToUnit == "MILES") //INCH TO MILES
            {
                ToDistance = FromDistance / (double)INCH_IN_MILES;
            }
            if (FromUnit == "INCH" && ToUnit == "METERS") //INCH TO METRES
            {
                ToDistance = FromDistance * (double)INCH_IN_METERS;
            }
            if (FromUnit == "INCH" && ToUnit == "KELOMETER") //INCH TO KELOMETER
            {
                ToDistance = FromDistance / (double)INCH_IN_KELOMETER;
            }
            if (FromUnit == "INCH" && ToUnit == "MILLIMETER") //INCH TO MILLIMETER
            {
                ToDistance = FromDistance * (double)INCH_IN_MILLIMETER;
            }
            if (FromUnit == "INCH" && ToUnit == "INCH") //INCH TO INCH
            {
                ToDistance = FromDistance * (double)INCH_IN_INCH;
            }
        }

        ///<summary>
        /// This method prints the miles and feet
        ///</summary>
        public void PrintResult()
        {
            Console.WriteLine(FromDistance + " " + FromUnit + " is " + ToDistance + " " + ToUnit);
        }

    }
}
