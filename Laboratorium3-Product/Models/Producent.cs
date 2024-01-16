using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium3_Product.Models;

public class Producent
{
    [HiddenInput]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [ValidateNever]
    public string Country { get; set; }
    [HiddenInput]
    public int CountryId { get; set; }
    [ValidateNever]
    public List<SelectListItem> CountryList { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
}