using System;
using Data.Entities;
using Data.Migrations;

namespace Laboratorium3_Product.Models;

public class MemoryProducentService : IProducentService
{
    private Dictionary<int, Producent> _items = new Dictionary<int, Producent>();

    public int Add(Producent item)
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
    public List<Producent> FindAll()
    {
        return _items.Values.ToList();
    }
    public Producent? FindById(int id)
    {
        return _items[id];
    }
    public void Update(Producent item)
    {
        _items[item.Id] = item;
    }
}