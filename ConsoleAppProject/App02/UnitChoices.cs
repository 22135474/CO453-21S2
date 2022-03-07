using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// <author>
    /// Units for calulations
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