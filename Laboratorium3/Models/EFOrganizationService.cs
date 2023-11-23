using Data;
using Data.Entities;

namespace Laboratorium3.Models
{
    public class EFOrganizationService : IOrganizationService
    {

        private readonly AppDbContext _context;

        public EFOrganizationService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Organization organization)
        {
            var e =_context.Organization.Add(OrganizationMapper.ToEntity(organization));
            _context.SaveChanges();
            int id = e.Entity.Id;
            return id;
        }

        public void Delete(int id)
        {
            OrganizationEntity? find =_context.Organization.Find(id);
            if (find != null)
            {
                _context.Organization.Remove(find);
                _context.SaveChanges();

            }
        }

        public List<Organization> FindAll()
        {
            return _context.Organization.Select(e => OrganizationMapper.FromEntity(e)).ToList();
        }

        public Organization? FindById(int id)
        {
            OrganizationEntity? find = _context.Organization.Find(id);
            return find != null ? OrganizationMapper.FromEntity(find) : null;
        }

        public void Update(Organization organization)
        {
            _context.Organization.Update(OrganizationMapper.ToEntity(organization));
            _context.SaveChanges();
        }
    }
}