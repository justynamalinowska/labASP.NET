using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Xml.Linq;

namespace Laboratorium3_Product.Models
{
    public enum Quality
    {
        [Display(Name = "Low")] Low = 1,
        [Display(Name = "Normal")] Normal = 2,
        [Display(Name = "High")] High = 3,
	}
}