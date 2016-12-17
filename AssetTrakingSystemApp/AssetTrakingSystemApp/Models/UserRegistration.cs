using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetTrakingSystemApp.Models
{
    public class UserRegistration
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name Field is required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name Field is required")]
        public string LastName { get; set; }
        [DisplayName("Organization")]
        [Required(ErrorMessage = "Organization  Field is required")]
        public string Organization { get; set; }
        [DisplayName("Designation")]
        public string Designation { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email  Field is required")]
        public string Email { get; set; }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone  Field is required")]
        public string Phone { get; set; }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender  Field is required")]
        public string Gender { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password  Field is required")]
        public string Password { get; set; }
    }
}