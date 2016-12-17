using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AssetTrakingSystemApp.Models;

namespace AssetTrakingSystemApp.Contex
{
    public class AssetDbContex:DbContext
    {

        public AssetDbContex()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationBranch> OrganizationBranches { get; set; }
        public DbSet<AssetLocation> AssetLocations { get; set; }
        public DbSet<GeneralCatagory> GeneralCatagories { get; set; } 
        public DbSet<CategorySetup> CategorySetups { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<UserRegistration> UserRegistrations { get; set; }

    }
}