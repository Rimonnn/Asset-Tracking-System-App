using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class UserRegistrationRepositoy
    {
        AssetDbContex db = new AssetDbContex();
        public bool Add(UserRegistration userRegistration)
        {
            db.UserRegistrations.Add(userRegistration);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;
        }

        public List<UserRegistration> GetAll()
        {
            var UserRegistrationList = db.UserRegistrations.ToList();
            return UserRegistrationList.ToList();
        }

        public bool IsEmailExist(string email)
        {
            if (db.UserRegistrations.Any(c => c.Email == email))
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