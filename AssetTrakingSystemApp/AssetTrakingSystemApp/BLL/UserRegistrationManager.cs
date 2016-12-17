using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class UserRegistrationManager
    {
        UserRegistrationRepositoy repositoy=new UserRegistrationRepositoy();
        public bool Add(UserRegistration userRegistration)
        {
            return repositoy.Add(userRegistration);
        }

        public List<UserRegistration> GetAll()
        {
            return repositoy.GetAll();
        }

        public bool IsEmailExist(string email)
        {
            return repositoy.IsEmailExist(email);
        }
    }
}