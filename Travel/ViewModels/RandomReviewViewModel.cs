using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Models;

namespace Travel.ViewModels
{
    public class RandomReviewViewModel
    {
        public Review Review { get; set; }
        public List<Reviewer> Reviewers { get; set; }

    }
}