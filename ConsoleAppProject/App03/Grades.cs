using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Display(Name = "Fail")]
        [Description("Referred")]
        F,
        [Display(Name = "III")]
        [Description("BSc(Hons) Third Class")]
        D,
        [Display(Name = "II-2")]
        [Description("BSc(Hons) Lower Second")]
        C,
        [Display(Name = "II-1")]
        [Description("BSc(Hons) Upper Second")]
        B,
        [Display(Name = "1st")]
        [Description("BSc(Hons) First Class")]
        A
    }
    public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calulator");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022  ");
            Console.WriteLine("    By Stefan Allen  ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();

            InputStudent();

            CalculateMark ();

            OutputResult();

            StudentSort();

            PrintPieChart();
        }

        private void InputStudent()
        {

        }

        private void CalculateMark()
        {

        }

        private void OutputResult()
        {

        }

        private void StudentSort() {

        }

        private void PrintPieChart()
        {

        }
}
