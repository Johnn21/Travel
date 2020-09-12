using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Models;


namespace Travel.ViewModels
{
    public class TravelReviewModel
    {
        public Travels Travel { get; set; }
        public List<Review> Reviews { get; set; }
    }
}