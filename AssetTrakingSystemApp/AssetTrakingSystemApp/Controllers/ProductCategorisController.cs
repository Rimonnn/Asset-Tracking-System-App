using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;


namespace AssetTrakingSystemApp.Controllers
{
    public class ProductCategorisController : Controller
    {
        ProductCategoriesManager productCategoriesManager=new ProductCategoriesManager();
        SubCategoryManager subCategoryManager=new SubCategoryManager();
        CategorySetupManager categorySetupManager=new CategorySetupManager();
        GeneralCategoryManager generalCategoryManager=new GeneralCategoryManager();
        //
        // GET: /ProductCategoris/
        [HttpGet]
        public ActionResult Save()
        {
            List<ProductCategory> productCategories = productCategoriesManager.GetAll();
            ViewBag.ProducCategoriesList = productCategories;
            List<SubCategory> subCategories = subCategoryManager.GetAll();
            ViewBag.SubCategoriesList = subCategories;
            List<CategorySetup> categorySetups = categorySetupManager.GetAll();
            ViewBag.ProducCategoriesList = categorySetups;
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralCategorisList = generalCatagories;
            return View();
        }
        [HttpPost]
        public ActionResult Save(ProductCategory productCategory)
        {
            List<ProductCategory> productCategories = productCategoriesManager.GetAll();
            ViewBag.ProducCategoriesList = productCategories;
            List<SubCategory> subCategories = subCategoryManager.GetAll();
            ViewBag.SubCategoriesList = subCategories;
            List<CategorySetup> categorySetups = categorySetupManager.GetAll();
            ViewBag.ProducCategoriesList = categorySetups;
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralCategorisList = generalCatagories;

            if (productCategory.Name == null || productCategory.Code == null || productCategory.GeneralCategoryId == 0 ||
                productCategory.CategorySetupId == 0 || productCategory.SubCategoryId == 0)
            {
                ViewBag.message = "Input field is requird";
            }
            else
            {
                if (productCategory.Code.Length > 5)
                {
                    ViewBag.message = "code lenth is greater than 5 which is not allowed";
                }
                else
                {
                    bool isCodeExist = productCategoriesManager.isCodeExist(productCategory.Code);
                    if (isCodeExist)
                    {
                        ViewBag.message = "Code is already exist";
                    }
                    else
                    {
                        bool save = productCategoriesManager.Add(productCategory);
                        if (save)
                        {
                            ViewBag.message = "Save successfull";
                        }
                        else
                        {
                            ViewBag.message = "Save failed";
                        }
                    }
                }
            }
         
            
            return View();
        }
        public JsonResult GetCategorySetupIdByGeneralCategoryId(int generalCategoryId)
        {
            var CategorySetupIdLists = categorySetupManager.GetCategorySetupIdByGeneralCategoryId(generalCategoryId);
            return Json(CategorySetupIdLists, JsonRequestBehavior.AllowGet);
        }
	}
}