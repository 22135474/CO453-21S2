using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double miles;
        private double feet;
        private Distanceunits distanceunits;

        public void Run()
        {
            Outputheading();

            InputToUnit();
            InputFromUnit();
        }

        private void Output()
        {
            Console.WriteLine(FromDistance + " " + fromUnit + ToDistance + " " + toUnit);
        }

        private void EnterUnit()
        {
            Console.WriteLine("Enter the fromDistance");
            Console.Write("Feet");
            Console.WriteLine("Metres");
            Console.Write("Miles");
        }

        private void InputMiles()
        {
            Console.Write("Pleae enter the number of miles >");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value); 
        }

        private void Inputfeet()
        {
            Console.Write("Pleae enter the number of feet >");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value); 
        }

        private void InputMetres()
        {
            Console.Write("Pleae enter the number of Metres >");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value); 
        }

        private void InputFromDistance()
        {

        }

        private void CovertMilesToFeet()
        {
            feet = miles = 5280;
        }

        private void CalculateToDistance()
        {
            if(fromUnit.Contains("miles", StringComparison.CurrentCultureIgnoreCase)
            && toUnit.Contains("Feet"))
            {
                toDistance = fromDistance = 5280;
            }
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
