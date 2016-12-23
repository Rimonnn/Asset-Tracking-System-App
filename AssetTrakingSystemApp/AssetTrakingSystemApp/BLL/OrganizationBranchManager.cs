using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
   
    public class OrganizationBranchManager
    {
        OrganizationBranchRepository repository=new OrganizationBranchRepository();
        public bool Add(OrganizationBranch organizationBranch)
        {
            if (organizationBranch == null)
            {
                return false;
            }
            return repository.Add(organizationBranch);

        }

        public bool IsShortNameExist(string shortName)
        {
            return repository.IsShortNameExist(shortName);
        }

        public List<OrganizationBranch> OrganizationBranches()
        {
            return repository.OrganizationBranches();
        }

        public List<OrganizationBranch> GetOrganizationBranchIdByOrganizationId(int organizationId)
        {
            return repository.GetOrganizationBranchIdByOrganizationId(organizationId);
        }
    }
}