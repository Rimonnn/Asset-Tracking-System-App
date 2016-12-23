using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryManager subCategoryManager=new SubCategoryManager();
       GeneralCategoryManager generalCategoryManager=new GeneralCategoryManager();
        CategorySetupManager categorySetupManager=new CategorySetupManager();
        //
        // GET: /SubCategory/
        [HttpGet]
        public ActionResult Save()
        {
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralcategoryList = generalCatagories;
            List<CategorySetup> categorySetups = categorySetupManager.GetAll();
            ViewBag.CategorySetupList = categorySetups;
            List<SubCategory> subCategories = subCategoryManager.GetAll();
            ViewBag.SubCategoryList = subCategories;
            return View();
        }
        [HttpPost]
        public ActionResult Save(SubCategory subCategory)
        {
            List<SubCategory> subCategories = subCategoryManager.GetAll();
            ViewBag.SubCategoryList = subCategories;
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralcategoryList = generalCatagories;
             List<CategorySetup> categorySetups = categorySetupManager.GetAll();
            ViewBag.CategorySetupList = categorySetups;

            if (subCategory.Name == null || subCategory.Code == null || subCategory.CategorySetupId == 0 ||
                subCategory.GeneralCtegoryId == 0)
            {
                ViewBag.message = "input field is requird";
            }
            else
            {
                if (subCategory.Code.Length > 5)
                {
                    ViewBag.message = "Code lenth is greatr than 5 not allowed";
                }
                else
                {
                    bool IsCodeExist = subCategoryManager.isCodeExist(subCategory.Code);
                    if (IsCodeExist)
                    {
                        ViewBag.message = "code is already exist !";
                    }
                    else
                    {
                        bool Save = subCategoryManager.Add(subCategory);
                        if (Save)
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

        public JsonResult GetSubCategoryIdByCategorySetupId(int CategorySetupId)
        {
            var subCategoriesLists = subCategoryManager.GetSubCategoryIdByCategorySetupId(CategorySetupId);
            return Json(subCategoriesLists, JsonRequestBehavior.AllowGet);
        }
	}
}