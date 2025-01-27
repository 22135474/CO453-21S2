﻿using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// <author>
    /// units for measurements
    /// Stefan Allen
    /// </author>
    public enum UnitsList
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Feet,
        Inches,
        Stones,
        Pounds,
        Metres,
        Centimetres,
        Kilograms,
        Grams
    }
}
