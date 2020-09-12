using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class Reviewer
    {
        [Key]
        public int reviewerId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Username")]
        public string userNameReviewer { get; set; }

        [Required]
        [Display(Name = "Password")]
        public int passwordReviewer { get; set; }

        [Display(Name = "Email Address")]
        public string emailAddressReviewer { get; set; }

    }
}