using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Main header output
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022  ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();

            //selecter for different apps
            string[] choices =
            {
                " Distance Converter",
                " BMI Calculator",
                " Student Grades",
                " Social Posts",
            };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Which Application would you like to use ?");
            Console.WriteLine();

            int choice = ConsoleHelper.SelectChoice(choices);
            switch (choice)
            {
                case 1:
                    DistanceConverter converter = new DistanceConverter();
                    converter.Run();
                    break;
                case 2:
                    BMICalculator app02 = new BMICalculator();
                    app02.Run();
                    break;
                case 3:
                    StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;
                case 4:
                    NewsApp socialApp = new NewsApp();
                    socialApp.DisplayMenu();
                    break;
                default:
                    break;
            }
        }
    }
}