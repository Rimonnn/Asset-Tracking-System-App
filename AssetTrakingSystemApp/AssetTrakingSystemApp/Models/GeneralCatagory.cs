using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class GeneralCatagory
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }
        [DisplayName("Code")]
        [Required(ErrorMessage = "Code Field is required")]
        [MaxLength(2)]
        public string Code { get; set; }
        public virtual List<CategorySetup> CategoySetups { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}