using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class ProductCategorisRepository
    {
        AssetDbContex db = new AssetDbContex();
        public bool Add(ProductCategory  productCategory)
        {
            db.ProductCategories.Add(productCategory);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;
        }

        public List<ProductCategory> GetAll()
        {
            
            var productCategoryList = db.ProductCategories.AsQueryable().ToList();
            return productCategoryList.ToList();
        }

        public bool isCodeExist(string code)
        {
            if (db.ProductCategories.Any(c => c.Code == code))
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