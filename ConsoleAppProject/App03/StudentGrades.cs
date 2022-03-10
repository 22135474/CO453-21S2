using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// <author>
    /// units for measurements
    /// Stefan Allen
    /// </author>
    public enum StudentGrades
    {
        [Display(Name = "No Unit")]
        GradeA,
        GradeB,
        GradeC,
        GradeD,
        GradeF
    }
}