using System;
using Data.Entities;

namespace Laboratorium3.Models
{

    public class MemoryOrganizationService : IOrganizationService
    {
        private Dictionary<int, Organization> _items = new Dictionary<int, Organization>();
        private IDateTimeProvider _timeProvider;

        public MemoryOrganizationService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(Organization item)
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
        public List<Organization> FindAll()
        {
            return _items.Values.ToList();
        }
        public Organization? FindById(int id)
        {
            return _items[id];
        }
        public void Update(Organization item)
        {
            _items[item.Id] = item;
        }
    }
}