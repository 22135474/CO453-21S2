using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// <author>
    /// Stefan Allen
    /// </author>
    public class BMICalculator
    {
        public const double BMI_UNDERWEIGHT = 18.5;
        public const double BMI_NORMAL = 18.5;
        public const int BMI_OVERWEIGHT = 25;
        public const int BMI_OBESE_I = 30;
        public const int BMI_OBESE_II = 35;
        public const int BMI_OBESE_III = 40;

        public const string UNDERWEIGHT = "Underweight";
        public const string NORMAL = "Normal";
        public const string OVERWEIGHT = "Overweight";
        public const string CLASS_I_OBESE = "Class I Obese";
        public const string CLASS_II_OBESE = "Class II Obese";
        public const string CLASS_III_OBESE = "Class III Obese";

        public double Feet { get; set; }
        public double Inches { get; set; }
        public double Metres { get; set; }
        public double Centimetres { get; set; }
        public double Stones { get; set; }
        public double Pounds { get; set; }
        public double Kilograms { get; set; }

        public UnitChoices UnitChoice { get; set; }

        public string Category { get; set; }

        public double BMI { get; set; }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calulator");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            UnitChoice = SelectUnit(" Please Choose whether to use Imperial or Metric Units");
            Console.WriteLine($" You have chosen {UnitChoice} Units");
            Console.WriteLine();

            InputMeasurement();

            CalculateBMI();

            OutputBMI();
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        private void InputMeasurement()
        {
            if (UnitChoice.Equals(UnitChoices.Imperial))
            {
                Console.WriteLine($" Please enter your Height in {UnitsList.Feet} and " +
                    $"{UnitsList.Inches}");
                Feet = ConsoleHelper.InputNumber($" {UnitsList.Feet} > ");
                Inches = ConsoleHelper.InputNumber($" {UnitsList.Inches} > ");
                Console.WriteLine();
                Console.WriteLine($" Please enter your Weight in {UnitsList.Stones} and" +
                    $" {UnitsList.Pounds}");
                Stones = ConsoleHelper.InputNumber($" {UnitsList.Stones} > ");
                Pounds = ConsoleHelper.InputNumber($" {UnitsList.Pounds} > ");
            }

            if (UnitChoice.Equals(UnitChoices.Metric))
            {
                Console.WriteLine($" Please enter your Height in {UnitsList.Centimetres}");
                Centimetres = ConsoleHelper.InputNumber($" {UnitsList.Centimetres} > ");
                Console.WriteLine();
                Console.WriteLine($" Please enter your Weight in {UnitsList.Grams}");
                Kilograms = ConsoleHelper.InputNumber($" {UnitsList.Kilograms} > ");
            }
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        private UnitChoices SelectUnit(string prompt)
        {
            string[] choices =
            {
                $" {UnitChoices.Imperial}",
                $" {UnitChoices.Metric}"
            };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteChoice(choice);
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        private static UnitChoices ExecuteChoice(int choice)
        {
            switch (choice)
            {
                case 1: return UnitChoices.Imperial;
                case 2: return UnitChoices.Metric;

                default: return UnitChoices.NoUnit;
            }
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        public void CalculateBMI()
        {
            if (UnitChoice.Equals(UnitChoices.Imperial))
            {
                Inches = (Feet * 12) + Inches;
                BMI = ((Stones * 14) + Pounds) * 703 / (Inches * Inches);
            }

            if (UnitChoice.Equals(UnitChoices.Metric))
            {
                Metres = Centimetres / 100;
                BMI = Kilograms / (Metres * Metres);
            }

            CatagoriesBMI();
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        public void CatagoriesBMI()
        {
            if (BMI < BMI_UNDERWEIGHT)
            {
                Category = UNDERWEIGHT;
            }
            else if (BMI >= BMI_NORMAL && BMI < BMI_OVERWEIGHT)
            {
                Category = NORMAL;
            }
            else if (BMI >= BMI_OVERWEIGHT && BMI < BMI_OBESE_I)
            {
                Category = OVERWEIGHT;
            }
            else if (BMI >= BMI_OBESE_I && BMI < BMI_OBESE_II)
            {
                Category = CLASS_I_OBESE;
            }
            else if (BMI >= BMI_OBESE_II && BMI < BMI_OBESE_III)
            {
                Category = CLASS_II_OBESE;
            }
            else if (BMI >= BMI_OBESE_III)
            {
                Category = CLASS_III_OBESE;
            }
        }

        /// <summary>
        /// <author>
        /// Stefan Allen
        /// </author>
        public void OutputBMI()
        {
            Console.WriteLine();
            Console.WriteLine($" Your BMI is {BMI}. " +
                $"You are in the {Category} Range");
        }
    }
}