using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class Review
    {
        [Key]
        public int idReview { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Review Name")]
        public string nameReview { get; set; }

        [Required]
        [Display(Name = "Review Relevance")]
        public int relevanceReview { get; set; }

        [Required]
        [Display(Name = "Review Overall")]
        public int overallRating { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Review Location")]
        public string locationReview { get; set; }

        [Required]
        [Display(Name = "Review Description")]
        public string descriptionReview { get; set; }

        /* public int idTravel { get; set; }
         [ForeignKey("idTravel")]
         public virtual Travels Travel { get; set; }


         public int reviewerId { get; set; }
         [ForeignKey("reviewerId")]
         public virtual Reviewer Reviewer { get; set; }*/
    }
}