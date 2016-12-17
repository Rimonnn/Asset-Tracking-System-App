using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }
        [DisplayName("Code")]
        [Required(ErrorMessage = "Code Field is required")]
        [MaxLength(3)]
        public string Code { get; set; }
        [DisplayName("Location")]
        [Required(ErrorMessage = "Location Field is required")]
        public string Location { get; set; }

        public virtual List<OrganizationBranch> OrganizationBranches { get; set; }
        public virtual List<AssetLocation> AssetLocations { get; set; } 
    }
}