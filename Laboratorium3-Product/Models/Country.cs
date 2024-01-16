using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium3_Product.Models
{
	public class Country
	{
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must write down country of origin!")]
        [StringLength(maximumLength: 50, ErrorMessage = "It is too long! Maximum length is 50 chars.")]
        [Display(Name = "Country of origin")]
        public string Name { get; set; }
    }
}

