using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class OrganizationRepository
    {
        AssetDbContex db=new AssetDbContex();
       
        public bool Add(Organization organization)
        {
            db.Organizations.Add(organization);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;
        }

        public List<Organization> GetAll()
        {
            var OrganizationList = db.Organizations.ToList();

            return OrganizationList.ToList();
        }

        public bool IsCodeExist(string code)
        {
            if (db.Organizations.Any(c => c.Code == code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}