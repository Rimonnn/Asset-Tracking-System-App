using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    
    public class GeneralCategoryRepository
    {
        AssetDbContex db=new AssetDbContex();
        public bool Add(GeneralCatagory generalCatagory)
        {
            db.GeneralCatagories.Add(generalCatagory);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;          
        }

        public List<GeneralCatagory> GetAll()
        {
            var generalCatagoryList = db.GeneralCatagories.ToList();
            return generalCatagoryList.ToList();
        }

        public bool isCodeExist(string code)
        {
            if (db.GeneralCatagories.Any(c => c.Code == code))
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