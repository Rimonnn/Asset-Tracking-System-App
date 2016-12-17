using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class AssetLocation
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }
        [DisplayName("Short Name")]
        [Required(ErrorMessage = "Short Name Field is required")]
        [MaxLength(5)]
        public string ShortName { get; set; }
        [DisplayName("Organization branch")]
        [Required(ErrorMessage = "Organization branch  Field is required")]
        public int OrganaizationBranchId { get; set; }
        [DisplayName("Organization")]
        [Required(ErrorMessage = "Organizaion Field is required")]
        public int OrganigationId { get; set; }
        public virtual OrganizationBranch OrganizationBranch { get; set; }
        public virtual Organization Organization { get; set; }
    }
}