using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must write down your name!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Your name is too long! Maximum length is 50 chars")]
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone No")]
        public string? Phone { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priority")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
        [HiddenInput]
        public int OrganizationId { get; set; }
        [ValidateNever]
        public List<SelectListItem> OrganizationList { get; set; }
    }
}
