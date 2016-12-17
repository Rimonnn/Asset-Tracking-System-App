using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace AssetTrakingSystemApp.Models
{
    public class CategorySetup
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string  Name { get; set; }
        [DisplayName("Code")]
        [Required(ErrorMessage = "Code Field is required")]
        [MaxLength(5)]
        public string Code { get; set; }
        [DisplayName("General Category")]
        public int GeneralCategoryId { get; set; }
        public virtual GeneralCatagory GeneralCatagory { get; set; }

        public virtual List<SubCategory> SubCategories { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }

    }
}