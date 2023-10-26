using System;
using Laboratorium3_Product.Models;

namespace Laboratorium3.Models
{

    public class MemoryProductService : IProductService
    {
        private Dictionary<int, Product> _items = new Dictionary<int, Product>();
        //private IDateTimeProvider _timeProvider;

        //public MemoryContactService(IDateTimeProvider timeProvider)
        //{
        //    _timeProvider = timeProvider;
        //}

        public int Add(Product item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            //item.Created = _timeProvider.GetDateTime();
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
    }
}

