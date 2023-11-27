using System;
using Data.Entities;


namespace Laboratorium3_Product.Models
{
    public interface IProductService
    {
        int Add(Product product);
        void Delete(int id);
        void Update(Product product);
        List<Product> FindAll();
        Product? FindById(int id);
        List<ProducentEntity> FindAllProducents();
    }
}

