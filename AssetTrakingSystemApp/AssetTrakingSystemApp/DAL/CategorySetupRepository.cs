using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class CategorySetupRepository
    {
        AssetDbContex db = new AssetDbContex();
        public bool Add(CategorySetup categorySetup)
        {
            db.CategorySetups.Add(categorySetup);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;
        }

        public List<CategorySetup> GetAll()
        {
            var CategorySetupList = db.CategorySetups.ToList();
            return CategorySetupList.ToList();
        }

        public bool isCodeExist(string code)
        {
            if (db.CategorySetups.Any(c => c.Code == code))
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