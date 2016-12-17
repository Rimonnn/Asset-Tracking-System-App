using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class SubCategoryManager
    {
        SubCategoryRepository repository=new SubCategoryRepository();
        public bool Add(SubCategory subCategory)
        {
            return repository.Add(subCategory);
        }

        public List<SubCategory> GetAll()
        {
            return repository.GetAll();
        }

        public bool isCodeExist(string code)
        {
            return repository.isCodeExist(code);
        }
    }
}