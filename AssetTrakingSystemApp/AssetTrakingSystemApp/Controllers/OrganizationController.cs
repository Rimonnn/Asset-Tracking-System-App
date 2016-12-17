using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager manager=new OrganizationManager();
        //
        // GET: /Organization/
        [HttpGet]
        public ActionResult Save()
        {
            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Save(Organization organization)
        {
            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();
            bool IsCodeExit = manager.IsCodeExist(organization.Code);
            if (IsCodeExit)
            {
                ViewBag.message = "Code is already exist";
            }
            else
            {
                bool Save = manager.Add(organization);
                if (Save)
                {
                    ViewBag.message = "Saved Successfull";
                }
                else
                {
                    ViewBag.message = "Saved Failed";
                }  
            }
           

            return View();
        }
	}
}