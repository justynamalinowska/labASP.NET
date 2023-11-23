using System;
using Laboratorium3.Models;    
using Data.Entities;
using Data.Models;

namespace Laboratorium3.Models
{
    public static class OrganizationMapper
    {
        public static OrganizationEntity ToEntity(Organization model)
        {
            Address address = new Address();
            address.City = model.City;
            address.Street = model.Street;
            address.PostalCode = model.PostalCode;
            return new OrganizationEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Address = address
            };
        }

        public static Organization FromEntity(OrganizationEntity model)
        {
            Address address = new Address();
            return new Organization()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                City = model.Address?.City,
                Street = model.Address?.Street,
                PostalCode = model.Address?.PostalCode
            };
        }
    }
}
