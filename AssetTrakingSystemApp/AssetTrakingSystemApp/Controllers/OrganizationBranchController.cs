using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class OrganizationBranchController : Controller
    {
        OrganizationManager manager=new OrganizationManager();
        OrganizationBranchManager orgBranchManager=new OrganizationBranchManager();
        //
        // GET: /OrganizationBranch/
        [HttpGet]
        public ActionResult Save()
        {
            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();
            List<OrganizationBranch> organizationBranches = orgBranchManager.OrganizationBranches();
            ViewBag.OrgBranchList = organizationBranches;
            return View();
        }
        [HttpPost]
        public ActionResult Save(OrganizationBranch orgBranch)
        {
            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();

            List<OrganizationBranch> organizationBranches = orgBranchManager.OrganizationBranches();
            ViewBag.OrgBranchList = organizationBranches;

            bool IsShortNameExist = orgBranchManager.IsShortNameExist(orgBranch.ShortName);

           
            if (IsShortNameExist)
            {
                ViewBag.message = "Short Name is already exist !";
            }
            else
            {
                bool Save = orgBranchManager.Add(orgBranch);
                if (Save)
                {
                    ViewBag.message = "Save Successful";
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