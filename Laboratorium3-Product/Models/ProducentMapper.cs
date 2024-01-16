using System;  
using Data.Entities;
using Data.Migrations;
using Data.Models;
namespace Laboratorium3_Product.Models;

public static class ProducentMapper 
{
    public static ProducentEntity ToEntity(Producent model)
    {
        Location location = new Location();
        location.City = model.City;
        location.Street = model.Street;
        location.PostalCode = model.PostalCode;
        return new ProducentEntity()
        {
            Id = model.Id,
            Name = model.Name,
            Description = model.Description,
            Location = location,
            CountryId = model.CountryId
        };
    }
    public static Producent FromEntity(ProducentEntity model)
    {
        Location location = new Location();
        return new Producent()
        {
            Id = model.Id,
            Name = model.Name,
            Description = model.Description,
            City = model.Location?.City,
            Street = model.Location?.Street,
            PostalCode = model.Location?.PostalCode,
            CountryId = model.CountryId
        };
    }
}