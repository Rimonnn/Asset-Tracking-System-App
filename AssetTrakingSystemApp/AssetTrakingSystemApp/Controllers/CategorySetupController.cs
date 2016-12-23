using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class CategorySetupController : Controller
    {
        CategorySetupManager manager=new CategorySetupManager();
        GeneralCategoryManager generalCategoryManager=new GeneralCategoryManager();
        //
        // GET: /CategorySetup/
        [HttpGet]
        public ActionResult Save()
        {
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralCategoryList = generalCatagories;
            List<CategorySetup> categorySetups = manager.GetAll();
            ViewBag.CategorySetupList = categorySetups;
            return View();
        }
        [HttpPost]
        public ActionResult Save(CategorySetup categorySetup)
        {
            List<GeneralCatagory> generalCatagories = generalCategoryManager.GetAll();
            ViewBag.GeneralCategoryList = generalCatagories;
            List<CategorySetup> categorySetups = manager.GetAll();
            ViewBag.CategorySetupList = categorySetups;
            if (categorySetup.Name == null || categorySetup.Code == null || categorySetup.GeneralCategoryId == 0)
            {
                ViewBag.message = "input field is requird";
            }
            else
            {
                if (categorySetup.Code.Length > 5)
                {
                    ViewBag.message = "Code lenth is greater than 5 not allowed";
                }
                else
                {
                    bool IscodeExist = manager.isCodeExist(categorySetup.Code);
                    if (IscodeExist)
                    {
                        ViewBag.message = "Code is already exist";
                    }
                    else
                    {
                        bool Save = manager.Add(categorySetup);
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
	}
}