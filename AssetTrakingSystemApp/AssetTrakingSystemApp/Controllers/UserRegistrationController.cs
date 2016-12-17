using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTrakingSystemApp.BLL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Controllers
{
    public class UserRegistrationController : Controller
    {
        UserRegistrationManager registrationManager=new UserRegistrationManager();
        //
        // GET: /UserRegistration/
    [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(UserRegistration registration)
        {
            bool isEmailExist = registrationManager.IsEmailExist(registration.Email);
            if (isEmailExist)
            {
                ViewBag.message = "Email is already exist";
            }
            else
            {
                bool save = registrationManager.Add(registration);
                if (save)
                {
                    ViewBag.message = "Save successfull";
                }
                else
                {
                    ViewBag.message = "sorry! Save failed";
                }
            }
            return View();
        }
	}
}