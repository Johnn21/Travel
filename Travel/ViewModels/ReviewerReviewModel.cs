using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Models;

namespace Travel.ViewModels
{
    public class ReviewerReviewModel
    {
        public Reviewer Reviewer { get; set; }
        public Review Reviews { get; set; }
    }
}