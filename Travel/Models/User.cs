using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class User
    {
        [Key]
        public int idUser { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string firstNameUser { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string lastNameUser { get; set; }

        [Display(Name = "Phone Number")]
        public int? phoneUser { get; set; }

        [Display(Name = "Email Address")]
        public string emailAddressUser { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Username")]
        public string userNameUser { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Password")]
        public string passwordUser { get; set; }
    }
}