using Data;
using Data.Entities;

namespace Laboratorium3.Models
{
    public class EFContactService : IContactService
    {

        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e =_context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
            int id = e.Entity.ContactId;
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? find =_context.Contacts.Find(id);
            if (find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();

            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
           return _context.Organization.ToList();
        }

        public List<Contact> FindPage(int page, int size)
        {
            throw new NotImplementedException();
            // int totalCount = _context.Contacts.Count(); 
            // List<ContactEntity> data = _context.Contacts
            //     .OrderBy(c => c.Name)
            //     .Skip((page - 1) * size)
            //     .Take(size)
            //     .ToList();
            // return PagingList<Contact>.Create(data, totalCount, page, size);
        }

        public Contact? FindById(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            return find != null ? ContactMapper.FromEntity(find) : null;
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
        }
    }
}
