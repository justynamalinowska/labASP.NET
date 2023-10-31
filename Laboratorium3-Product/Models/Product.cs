using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3_Product.Models
{
	public class Product
	{
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must write down your name!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Your name is too long! Maximum length is 50 chars.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Producent { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of production")]
        public DateTime? DateOfProduction { get; set; }
        [MinLength(length: 10, ErrorMessage = "Your description is too short! Minimum length is 10 chars.")]
        [Required(ErrorMessage = "You must write down description for the product!")]
        public string Description { get; set; }
        [Display(Name = "Quality")]
        public Quality Quality { get; set; }
    }
}

