using System;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Laboratorium3_Product.Models
{
	public class EFProductService : IProductService
	{
        private readonly AppDbContext _context;
        
        public EFProductService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Product product)
        {
            var e = _context.Products.Add(ProductMapper.ToEntity(product));
            _context.SaveChanges();
            int id = e.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            ProductEntity? find = _context.Products.Find(id);
            if (find != null)
            {
                _context.Products.Remove(find);
                _context.SaveChanges();

            }
        }

        public List<Product> FindAll()
        {
            return _context.Products.Select(e => ProductMapper.FromEntity(e)).ToList();
        }

        public Product? FindById(int id)
        {
            ProductEntity? find = _context.Products.Find(id);
            return find != null ? ProductMapper.FromEntity(find) : null;
        }

        public void Update(Product product)
        {
            _context.Products.Update(ProductMapper.ToEntity(product));
            _context.SaveChanges();
        }
    }
}

