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

        public PagingList<Contact> FindPage(int page, int size)
        {
            var pagingList = PagingList<Contact>.Create(null, _context.Contacts.Count(), page, size);
            var data = _context.Contacts
                .OrderBy(contact => contact.Name)
                .Skip((pagingList.Number - 1) * pagingList.Size)
                .Take(pagingList.Size)
                .Select(ContactMapper.FromEntity)
                .ToList();
            pagingList.Data = data;
            return pagingList;
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
