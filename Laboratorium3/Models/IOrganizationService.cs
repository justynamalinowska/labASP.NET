using System;
using Data.Entities;
using System.Collections.Generic;

namespace Laboratorium3.Models
{
    public interface IOrganizationService
    {
        int Add(Organization organization);
        void Delete(int id);
        void Update(Organization organization);
        List<Organization> FindAll();
        Organization? FindById(int id);
    }
}