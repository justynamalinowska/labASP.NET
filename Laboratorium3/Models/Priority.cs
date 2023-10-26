﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Laboratorium3.Models
{
    public enum Priority
    {
        [Display(Name = "Low")] Low = 1,
        [Display(Name = "Normal")] Normal = 2,
        [Display(Name = "High")] High = 3,
        [Display(Name = "Urgent")] Urgent = 4
    }
}

