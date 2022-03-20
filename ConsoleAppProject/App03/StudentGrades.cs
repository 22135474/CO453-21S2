using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }

        public void Run()
        {
            ConsoleHelper.OutputHeading("Student Grades App 03");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Students = new string[] { "Bob", "Ross", "Evey", "Jack", "Mo", "Arbaaz", "AK", "Stefan", 
            "Nick", "Ben"};
            Marks = new int[Students.Length];

            GradeProfile = new int[(int)Grades.A];
            Marks = new int[]
            {
                10, 20, 30, 40, 50,
                60, 70, 80, 90, 100
            };

            OutputMenuChoices();
        }

        public void OutputMenuChoices()
        {
            string[] choices =
            {
                " Input Marks",
                " MeanMark",
                " GradePercentage",
                " MinMarkMaxmark",
                " Quit"
            };

            int choice;
            choice = ExecuteChoice(choices);
        }

        private int ExecuteChoice(string[] choices)
        {
            int choice;
            do
            {
                choice = ConsoleHelper.SelectChoice(choices);
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        InputMarks();
                        OutputGrades();
                        break;
                    case 2:
                        MeanMark();
                        break;
                    case 3:
                        GradePercentage();
                        break;
                    case 4:
                        MinMarkMaxmark();
                        break;
                    case 5:
                        FullDetailedGrade();
                        break;
                    case 6:
                        exit();
                        break;
                    default:
                        break;
                }

            }
            while (choice != 5);
            return choice;
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < 39)
            {
                return Grades.F;
            }
            if (mark >= 40 && mark < 49)
            {
                return Grades.D;
            }
            if (mark >= 50 && mark < 59)
            {
                return Grades.C;
            }
            if (mark >= 60 && mark < 69)
            {
                return Grades.B;
            }
            if (mark >= 70 && mark <= 100)
            {
                return Grades.A;
            }
            else
            {
                return Grades.X;
            }
        }

        private void InputMarks()
        {
            Console.WriteLine("Please enter a mark for each student \n");
            int index = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name} enter mark > ", 0, 100);
                Marks[index] = mark;
            };
        }

        private void MeanMark()
        {
            int[] numbers;
            numbers = new int[10];
            Console.WriteLine("Give 10 student grades:");
            numbers[0] = Int32.Parse(Console.ReadLine());
            numbers[1] = Int32.Parse(Console.ReadLine());
            numbers[2] = Int32.Parse(Console.ReadLine());
            numbers[3] = Int32.Parse(Console.ReadLine());
            numbers[4] = Int32.Parse(Console.ReadLine());
            numbers[5] = Int32.Parse(Console.ReadLine());
            numbers[6] = Int32.Parse(Console.ReadLine());
            numbers[7] = Int32.Parse(Console.ReadLine());
            numbers[8] = Int32.Parse(Console.ReadLine());
            numbers[9] = Int32.Parse(Console.ReadLine());
            int sum = 0;

            foreach (int x in numbers)
            {
                sum += x;
            }
            int aver = sum / numbers.Length; Console.WriteLine("Mean Grade: {0}", aver);
        }


        private void MinMarkMaxmark()
        {
            int i;
            int[] a = new int[30];
            Console.Write("Enter the Number of values to find Smallest and Largest Number: ");
            int n = Convert.ToInt16(Console.ReadLine()); 

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The smallest Value is " + a[1]); 
            Console.WriteLine("The Largest Value is " + a[n]);
            Console.ReadKey();
        }
    
        static void GradePercentage()
        {
            int mark = (int)ConsoleHelper.InputNumber($"Enter mark > ", 0, 100);
            int sum = mark;
            Console.WriteLine($"{mark}% out of 100"); 
        }

        private void FullDetailedGrade()
        {
            
        }

        private void exit()
        {
            System.Environment.Exit(1);
        }

        private void OutputGrades()
        {
            for (int i = 0; i < 10; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                
                Console.WriteLine($"{Students[i]}'s Mark = {mark}, Grade = {grade}");
            }
        }
    }
}