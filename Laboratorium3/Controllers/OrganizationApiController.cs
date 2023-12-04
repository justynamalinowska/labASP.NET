using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3.Controllers
{
    [Route("api/organization")]
    [ApiController]
    public class OrganizationApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public OrganizationApiController(AppDbContext context)
        {
            _context = context;
        }
        
        //[Route("filter")]
        [HttpGet]
        public IActionResult GetFilteredOrganizations(string? q)
        {
            return Ok(
                q is null ? _context.Organization
                        .ToList()
                        .Select(o => new{ o.Name, o.Id})
                        .ToList()
                    :
                _context.Organization
                .Where(o => o.Name.ToUpper().StartsWith(q.ToUpper()))
                .Select(o => new { o.Name, o.Id })
                .ToList());
        }
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetOrganizationById(int id)
        {
            var entity = _context.Organization.Find(id);
            if (entity is null) return NotFound();
            else return Ok(entity);
        }
        
        
    }
}
