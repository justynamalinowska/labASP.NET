using Data;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3_Product.Controllers;

[Route("api/producent")]
[ApiController]
public class ProducentApiController : Controller
{
    private readonly AppDbContext _context;
        
    public ProducentApiController(AppDbContext context)
    {
        _context = context;
    }
        
    //[Route("filter")]
    [HttpGet]
    public IActionResult GetFilteredProducents(string? q)
    {
        return Ok(
            q is null ? _context.Producent
                    .ToList()
                    .Select(o => new{ o.Name, o.Id})
                    .ToList()
                :
                _context.Producent
                    .Where(o => o.Name.ToUpper().StartsWith(q.ToUpper()))
                    .Select(o => new { o.Name, o.Id })
                    .ToList());
    }
    [Route("{id}")]
    [HttpGet]
    public IActionResult GetProducentById(int id)
    {
        var entity = _context.Producent.Find(id);
        if (entity is null) return NotFound();
        else return Ok(entity);
    }
}