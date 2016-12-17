using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class GeneralCategoryManager
    {
        GeneralCategoryRepository repository=new GeneralCategoryRepository();

        public bool Add(GeneralCatagory generalCatagory)
        {
            if (generalCatagory.Code.Length>2)
            {
                return false;
            }
            return repository.Add(generalCatagory);
        }

        public List<GeneralCatagory> GetAll()
        {
            return repository.GetAll();
        }

        public bool isCodeExist(string code)
        {
            return repository.isCodeExist(code);
        }
    }
}