using Data;
using Data.Entities;
using Data.Migrations;

namespace Laboratorium3_Product.Models;

public class EFProducentService : IProducentService
{
    private readonly AppDbContext _context;

    public EFProducentService(AppDbContext context)
    {
        _context = context;
    }
    
    public int Add(Producent producent)
    {
        var e =_context.Producent.Add(ProducentMapper.ToEntity(producent));
        _context.SaveChanges();
        int id = e.Entity.Id;
        return id;
    }

    public void Delete(int id)
    {
        ProducentEntity? find =_context.Producent.Find(id);
        if (find != null)
        {
            _context.Producent.Remove(find);
            _context.SaveChanges();
        }
    }

    public void Update(Producent producent)
    {
        _context.Producent.Update(ProducentMapper.ToEntity(producent));
        _context.SaveChanges();
    }

    public List<Producent> FindAll()
    {
        return _context.Producent.Select(e => ProducentMapper.FromEntity(e)).ToList();
    }

    public Producent? FindById(int id)
    {
        ProducentEntity? find = _context.Producent.Find(id);
        return find != null ? ProducentMapper.FromEntity(find) : null;
    }
}