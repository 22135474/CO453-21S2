using ConsoleAppProject.Helpers;
using System;
using System.Runtime;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public void Run()
        {
            ConsoleHelper.OutputTitle("BMI Calulator");
            int choice = InputChoice();
        }

        private int InputChoice()
        {
            string[] choices = new string[]
                {
                    "Imperial Units",
                    "Metric Units"
                };

            ConsoleHelper.OutputTitle("Please select the units you wish to use");
            return ConsoleHelper.SelectChoice(choices);
        }
    }
}