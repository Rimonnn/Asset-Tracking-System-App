using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class SubCategoryRepository
    {
           AssetDbContex db=new AssetDbContex();
        public bool Add(SubCategory subCategory)
        {
            db.SubCategories.Add(subCategory);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;          
        }

        public List<SubCategory> GetAll()
        {
            var SubCategoryList = db.SubCategories.ToList();
            return SubCategoryList.ToList();
        }

        public bool isCodeExist(string code)
        {
            if (db.SubCategories.Any(c => c.Code == code))
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