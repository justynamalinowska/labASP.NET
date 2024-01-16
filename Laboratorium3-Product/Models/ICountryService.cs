using System;
using Data.Entities;
using System.Collections.Generic;
using Data.Migrations;

namespace Laboratorium3_Product.Models;

public interface ICountryService
{
    int Add(Country country);
    void Delete(int id);
    void Update(Country country);
    List<Country> FindAll();
    Country? FindById(int id);
}