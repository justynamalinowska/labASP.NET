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
    public class OrganizationAPIController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public OrganizationAPIController(AppDbContext context)
        {
            _context = context;
        }
        
        [Route("filter")]
        public IActionResult GetFilteredOrganizations(string q)
        {
            var result = _context.Organization
                .Where(o => o.Name.StartsWith(q.ToLower()))
                .Select(o => new { o.Name, o.Id })
                .ToList();

            return Ok(result);

        }
        [Route("{id}")]
        public IActionResult GetOrganizationById(int id)
        {
            var entity = _context.Organization.Find(id);
            if (entity is null) return NotFound();
            else return Ok();
        }
    }
}
