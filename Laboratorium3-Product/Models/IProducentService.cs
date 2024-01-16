using System;
using Data.Entities;
using System.Collections.Generic;
using Data.Migrations;

namespace Laboratorium3_Product.Models;

public interface IProducentService
{
    int Add(Producent producent);
    void Delete(int id);
    void Update(Producent producent);
    List<Producent> FindAll();
    Producent? FindById(int id);
    List<CountryEntity> FindAllCountries();
}