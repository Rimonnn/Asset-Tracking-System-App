using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;


namespace AssetTrakingSystemApp.BLL
{
    public class ProductCategoriesManager
    {
        ProductCategorisRepository repository=new ProductCategorisRepository();
        public bool Add(ProductCategory productCategory)
        {
            return repository.Add(productCategory);
        }

        public List<ProductCategory> GetAll()
        {
            return repository.GetAll();
        }

        public bool isCodeExist(string code)
        {
            return repository.isCodeExist(code);
        }
    }
}