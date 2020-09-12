using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;
using Travel.ViewModels;

namespace Travel.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review

        private ApplicationDbContext _context;

        public ReviewController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {        
          
            Review review = new Review();

            return View("New", review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review review)
        {
        
            if (!ModelState.IsValid)
            {
        
                return View("New", review);
            }

            if (review.idReview == 0)
                _context.Reviews.Add(review);
            else
            {
              //  var reviewerInDb = _context.Reviewers.Single(c => c.reviewerId == reviewer.reviewerId);
                var reviewInDb = _context.Reviews.Single(c => c.idReview == review.idReview);
                reviewInDb.locationReview = review.locationReview;
                reviewInDb.nameReview = review.nameReview;
                reviewInDb.overallRating = review.overallRating;
                reviewInDb.relevanceReview = review.relevanceReview;
                reviewInDb.descriptionReview = review.descriptionReview;
               // reviewInDb.reviewerId = reviewerInDb.reviewerId;
                
              

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Review");
        }

        public ActionResult Edit(int id)
        {
            var review = _context.Reviews.SingleOrDefault(c => c.idReview == id);

            if (review == null)
                return HttpNotFound();

            return View("New", review);

        }

        public ActionResult Acces()
        {
            return View("acces");

        }

        public class AccessDeniedAuthorizeAttribute : AuthorizeAttribute
        {
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                base.OnAuthorization(filterContext);
                if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    filterContext.Result = new RedirectResult("/user/acces");
                    return;
                }

                if (filterContext.Result is HttpUnauthorizedResult)
                {
                    filterContext.Result = new RedirectResult("/user/acces");
                }
            }
        }


        //[Authorize]
        [AccessDeniedAuthorize(Roles = "CanAdmin,CanMakeReview,userRole")]
        public ViewResult Index()
        {
            var review = _context.Reviews.ToList();

            if (User.IsInRole("CanMakeReview"))
                return View("ReviewDetailsList", review);
            else if (User.IsInRole("CanAdmin"))
                return View("Index", review);

            return View("ReviewDetailsList", review);
        }

        public ActionResult DetailsReview(int id)
        {

            var review = _context.Reviews.SingleOrDefault(c => c.idReview == id);

            if (review == null)
                return HttpNotFound();

            return View(review);
        }

        public ActionResult Random()
        {

            var review = new Review() { nameReview = "Review Name" };

            var reviewers = new List<Reviewer>
            {
                new Reviewer { userNameReviewer = "Reviewer 1"},
                new Reviewer { userNameReviewer = "Reviewer 2"}
            };

            var viewModel = new RandomReviewViewModel
            {
                Review = review,
                Reviewers = reviewers
            };

            return View(viewModel);
          
        } 

        
    }
}