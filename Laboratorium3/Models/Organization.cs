using System;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Models
{
    public class Organization
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
    }
}

