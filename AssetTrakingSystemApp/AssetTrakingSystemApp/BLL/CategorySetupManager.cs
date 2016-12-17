using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class CategorySetupManager
    {
        private CategorySetupRepository repository = new CategorySetupRepository();

        public bool Add(CategorySetup categorySetup)
        {
            return repository.Add(categorySetup);
        }

        public List<CategorySetup> GetAll()
        {
            return repository.GetAll();

        }

        public bool isCodeExist(string code)
        {
            return repository.isCodeExist(code);

        }

    }
}