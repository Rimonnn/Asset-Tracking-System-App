using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class OrganizationManager
    {
        OrganizationRepository repository=new OrganizationRepository();
        public bool Add(Organization organization)
        {
            if (organization == null)
            {
                return false;
            }
            if (organization.Code.Length > 3)
            {
                return false;
            }
            return repository.Add(organization);
        }

        public List<Organization> GetAll()
        {
            return repository.GetAll();
        }

        public bool IsCodeExist(string code)
        {
            return repository.IsCodeExist(code);
        }

    }
}