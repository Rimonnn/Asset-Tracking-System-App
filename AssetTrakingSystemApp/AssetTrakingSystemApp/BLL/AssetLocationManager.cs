using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.DAL;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.BLL
{
    public class AssetLocationManager
    {
        AssetLocationRepository repository=new AssetLocationRepository();
        public bool Add(AssetLocation assetLocation)
        {
            return repository.Add(assetLocation);
        }

        public bool IsShortNameExist(string sName)
        {
            return repository.IsShortNameExist(sName);
        }

        public List<AssetLocation> GetAll()
        {
            return repository.GetAll();
        }

    }
}