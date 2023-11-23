using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3_Product.Models;

public class Producent
{
    [HiddenInput]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
}