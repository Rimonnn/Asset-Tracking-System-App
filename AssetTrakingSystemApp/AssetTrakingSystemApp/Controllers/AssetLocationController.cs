﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class AssetLocationController : Controller
    {
        OrganizationBranchManager orgManager=new OrganizationBranchManager();
        OrganizationManager manager=new OrganizationManager();
        AssetLocationManager assetmanager=new AssetLocationManager();
        //
        // GET: /AssetLocation/
        [HttpGet]
        public ActionResult Save()
        {

            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();
            List<OrganizationBranch> organizationBranches = orgManager.OrganizationBranches();
            ViewBag.OrgBranchList = organizationBranches;
            List<AssetLocation> assetLocations = assetmanager.GetAll();
            ViewBag.AssetLocationList = assetLocations;
            return View();
        }
        [HttpPost]
        public ActionResult Save(AssetLocation assetLocation)
        {
            List<AssetLocation> assetLocations = assetmanager.GetAll();
            ViewBag.AssetLocationList = assetLocations;
            List<Organization> organizations = manager.GetAll();
            ViewBag.organizationList = organizations.ToList();
            List<OrganizationBranch> organizationBranches = orgManager.OrganizationBranches();
            ViewBag.OrgBranchList = organizationBranches;
            if (assetLocation.Name == null || assetLocation.ShortName == null || assetLocation.OrganigationId == 0 ||
                assetLocation.OrganigationId == 0)
            {
                ViewBag.message = "Input filed is requierd";
            }
            else
            {
                if (assetLocation.ShortName.Length > 5)
                {
                    ViewBag.message = "Short name filed is to be maximum 5 digit";
                }
                else
                {
                    bool IsShortNameExist = assetmanager.IsShortNameExist(assetLocation.ShortName);
                    if (IsShortNameExist)
                    {
                        ViewBag.message = "Short name is already exist !";

                    }
                    else
                    {
                        bool Save = assetmanager.Add(assetLocation);
                        if (Save)
                        {
                            ViewBag.message = "Save Location Successfull !";
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

        public JsonResult GetOrganizationBranchIdByOrganizationId(int organizationId)
        {
            var organaizationBranchLists = orgManager.GetOrganizationBranchIdByOrganizationId(organizationId);
            return Json(organaizationBranchLists, JsonRequestBehavior.AllowGet);
        }
	}
}