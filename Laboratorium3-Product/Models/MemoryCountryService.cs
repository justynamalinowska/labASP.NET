using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Laboratorium3_Product.Models
{
    public class MemoryCountryService : ICountryService
    {
        private Dictionary<int, Country> _items = new Dictionary<int, Country>();

        public int Add(Country item)
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
        public List<Country> FindAll()
        {
            return _items.Values.ToList();
        }
        public Country? FindById(int id)
        {
            if(_items.ContainsKey(id))
            {
                return _items[id];
            }
            return null;
        }

        public void Update(Country item)
        {
            _items[item.Id] = item;
        }
    }
}