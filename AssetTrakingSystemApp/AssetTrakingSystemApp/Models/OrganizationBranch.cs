using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class OrganizationBranch
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string ShortName { get; set; }
        [DisplayName("Organization")]
        [Required(ErrorMessage = "Organization can't empty")]
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual List<AssetLocation> AssetLocations { get; set; }

    }
}