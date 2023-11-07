using Data.Entities;

namespace Laboratorium3.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                ContactId = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                BirthDate = model.Birth,
                Priority = (int)model.Priority,

            };
        }
        public static Contact FromEntity(ContactEntity model)
        {
            return new Contact()
            {
                Id = model.ContactId,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = model.BirthDate,
                Priority = (Priority)model.Priority,
            };
        }
            
    }
}
