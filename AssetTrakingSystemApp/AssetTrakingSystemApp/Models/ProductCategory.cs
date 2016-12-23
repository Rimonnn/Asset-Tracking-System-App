using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }
        [DisplayName("Product Code")]
        [Required(ErrorMessage = "Product Code Field is required")]
        [MaxLength(5)]
        public string Code { get; set; }
        [DisplayName("Product Descrition")]
        public string ProductDescription { get; set; }
        [DisplayName("Sub Category")]
        [Required(ErrorMessage = "Sub Category Field is required")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [DisplayName("Category Setup")]
        [Required(ErrorMessage = "Category setup Field is required")]
        public int CategorySetupId { get; set; }
        public virtual CategorySetup CategorySetup { get; set; }
        [DisplayName("General Category")]
        [Required(ErrorMessage = "General Category Field is required")]
        public int GeneralCategoryId { get; set; }
        public virtual GeneralCatagory GeneralCatagory { get; set; }

    }
}