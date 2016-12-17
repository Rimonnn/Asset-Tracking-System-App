using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Contex;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.DAL
{
    public class AssetLocationRepository
    {
        AssetDbContex db=new AssetDbContex();

        public bool Add(AssetLocation assetLocation)
        {
            db.AssetLocations.Add(assetLocation);
            int rowsAffected = db.SaveChanges();

            return rowsAffected > 0;
        }
        public bool IsShortNameExist(string sName)
        {
            if (db.AssetLocations.Any(c => c.ShortName == sName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AssetLocation> GetAll()
        {
            var AssetLocationList = db.AssetLocations.ToList();
            return AssetLocationList.ToList();
        } 
    }
}