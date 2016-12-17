using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class OrganizationBranchRepository
    {
        AssetDbContex db=new AssetDbContex();
        public bool Add(OrganizationBranch organizationBranch)
        {
            db.OrganizationBranches.Add(organizationBranch);
            int rowsAffected = db.SaveChanges();
            return rowsAffected > 0;
        }

        public bool IsShortNameExist(string shortName)
        {
            if (db.OrganizationBranches.Any(c => c.ShortName == shortName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OrganizationBranch> OrganizationBranches()
        {
            var organizationBranches = db.OrganizationBranches.ToList();
            return organizationBranches;
        } 
    }
}