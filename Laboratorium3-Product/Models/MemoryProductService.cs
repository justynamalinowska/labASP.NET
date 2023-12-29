using System;
using Data.Entities;
using Laboratorium3_Product.Models;

namespace Laboratorium3_Product.Models
{

    public class MemoryProductService : IProductService
    {
        private Dictionary<int, Product> _items = new Dictionary<int, Product>();
        private List<ProducentEntity> _producents = new List<ProducentEntity>();

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
            if(_items.ContainsKey(id))
            {
                return _items[id];
            }
            return null;
        }
        public void Update(Product item)
        {
            _items[item.Id] = item;
        }
        public List<ProducentEntity> FindAllProducents()
        {
            return _producents;
        }

        public PagingList<Product> FindPage(int page, int size)
        {
            var allProducts = FindAll();
            int startIndex = (page - 1) * size;
            var productsOnPage = allProducts.Skip(startIndex).Take(size).ToList();
            return PagingList<Product>.Create(productsOnPage, allProducts.Count, page, size);
        }
    }
}

