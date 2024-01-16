using System;  
using Data.Entities;
using Data.Migrations;
using Data.Models;
namespace Laboratorium3_Product.Models;

public static class CountryMapper 
{
    public static CountryEntity ToEntity(Country model)
    {
        return new CountryEntity()
        {
            Id = model.Id,
            Name = model.Name,
        };
    }
    public static Country FromEntity(CountryEntity model)
    {
        return new Country()
        {
            Id = model.Id,
            Name = model.Name,
        };
    }
}