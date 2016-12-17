using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        
        public string Name { get; set; }
        
        [DisplayName("Code")]
        [Required(ErrorMessage = "Code Field is required")]
        [MaxLength(5)]
        public string Code { get; set; }
        [DisplayName("General Category")]
        [Required(ErrorMessage = "General category Field is required")]
        public int GeneralCtegoryId { get; set; }      
        public virtual GeneralCatagory GeneralCatagory { get; set; }
        [DisplayName("Category")]
        [Required(ErrorMessage = "category Field is required")]
        public int CategorySetupId { get; set; }
        public virtual CategorySetup CategorySetup { get; set; }
        

    }
}