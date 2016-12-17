using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    
    public class GeneralCategoryController : Controller
    {
        GeneralCategoryManager  manager=new GeneralCategoryManager();
        //
        // GET: /GeneralCategory/
        [HttpGet]
        public ActionResult Save()
        {
            List<GeneralCatagory> generalCatagories = manager.GetAll();
            ViewBag.GeneralCategoryList = generalCatagories;
            return View();
        }
        [HttpPost]
        public ActionResult Save(GeneralCatagory generalCatagory)
        {
            List<GeneralCatagory> generalCatagories = manager.GetAll();
            ViewBag.GeneralCategoryList = generalCatagories;

            bool IsCodeExist = manager.isCodeExist(generalCatagory.Code);
            if (IsCodeExist)
            {
                ViewBag.message = "Code is already exist !";
            }
            else
            {
                bool Save = manager.Add(generalCatagory);
                if (Save)
                {
                    ViewBag.message = "Save succesfull"; 
                }
                else
                {
                    ViewBag.message = "Save failed";
                }
               
            }
            return View();
        }
	}
}