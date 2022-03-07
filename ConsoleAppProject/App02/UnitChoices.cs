using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// <author>
    /// Stefan Allen
    /// </author>
    public enum UnitChoices
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Imperial,
        Metric
    }
}