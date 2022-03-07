using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        public static void OutputHeading(string title)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("--------------------------------");
        }

        public static string InputString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static void OutputIntroduction(string introduction)
        {
            Console.WriteLine("======= Introduction ====== ");
            Console.WriteLine(introduction);
        }

        public static void OutputMenu(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine(choiceNo + ". " + choice);
            }
        }
    }
}