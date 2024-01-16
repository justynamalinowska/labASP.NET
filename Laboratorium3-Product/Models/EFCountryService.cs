using System.Collections.Generic;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Laboratorium3_Product.Models
{
    public class EFCountryService : ICountryService
    {
        private readonly AppDbContext _context;

        public EFCountryService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Country country)
        {
            var entity = _context.Countries.Add(CountryMapper.ToEntity(country));
            _context.SaveChanges();
            int id = entity.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            CountryEntity? entity = _context.Countries.Find(id);
            if (entity != null)
            {
                _context.Countries.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<Country> FindAll()
        {
            return _context.Countries.Select(e => CountryMapper.FromEntity(e)).ToList();
        }

        public Country? FindById(int id)
        {
            CountryEntity? find = _context.Countries.Find(id);
            return find is not null ? CountryMapper.FromEntity(find) : null;
        }

        public void Update(Country country)
        {
            _context.Countries.Update(CountryMapper.ToEntity(country));
            _context.SaveChanges();
        }
    }
}