using System;
using Data.Entities;
using Laboratorium3_Product.Models;

namespace Laboratorium3_Product.Models
{

    public class MemoryProductService : IProductService
    {
        private Dictionary<int, Product> _items = new Dictionary<int, Product>();

        public int Add(Product item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            
            return item.Id;
        }
        public void Delete(int id)
        {
            _items.Remove(id);
        }
        public List<Product> FindAll()
        {
            return _items.Values.ToList();
        }
        public Product? FindById(int id)
        {
            return _items[id];
        }
        public void Update(Product item)
        {
            _items[item.Id] = item;
        }
        public List<ProducentEntity> FindAllProducents()
        {
            throw new NotImplementedException();
        }

        public PagingList<Product> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}

