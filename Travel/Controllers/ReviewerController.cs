using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class ReviewerController : Controller
    {
        // GET: Reviewer


        private ApplicationDbContext _context;

        public ReviewerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            Reviewer reviewer = new Reviewer();

            return View("New", reviewer);
        }

        public ActionResult Redirect()
        {
            return RedirectToAction("Index", "Reviewer/New");
        }

        public ActionResult RedirectToAddReview()
        {
            return RedirectToAction("Index", "Review/New");
        }

        public ActionResult RedirectToSeeReview()
        {
            return RedirectToAction("DetailsReview", "Review/DetailsReview");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reviewer reviewer)
        {
            if (!ModelState.IsValid)
            {
                return View("New", reviewer);
            }

            if (reviewer.reviewerId == 0)
                _context.Reviewers.Add(reviewer);
            else
            {
                var reviewerInDb = _context.Reviewers.Single(c => c.reviewerId == reviewer.reviewerId);

                reviewerInDb.userNameReviewer = reviewer.userNameReviewer;
                reviewerInDb.passwordReviewer = reviewer.passwordReviewer;
                reviewerInDb.emailAddressReviewer = reviewer.emailAddressReviewer;
 

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Reviewer");
        }

        public ActionResult Edit(int id)
        {
            var reviewer = _context.Reviewers.SingleOrDefault(c => c.reviewerId == id);

            if (reviewer == null)
                return HttpNotFound();

            return View("New", reviewer);

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
                    filterContext.Result = new RedirectResult("/reviewer/acces");
                    return;
                }

                if (filterContext.Result is HttpUnauthorizedResult)
                {
                    filterContext.Result = new RedirectResult("/reviewer/acces");
                }
            }
        }


        // [Authorize]
        [AccessDeniedAuthorize(Roles = "CanAdmin,CanMakeReview,userRole")]
        public ViewResult Index()
        {
            var reviewer = _context.Reviewers.ToList();

            if (User.IsInRole("CanMakeReview"))
                return View("ReviewerDetailsListForReviewer", reviewer);
            if (User.IsInRole("CanAdmin"))
                return View("Index", reviewer);

            return View("ReviewerDetailsList",reviewer);

          //  return View(reviewer);
        }

        public ActionResult DetailsReviewer(int id)
        {

            var reviewer = _context.Reviewers.SingleOrDefault(c => c.reviewerId == id);

            if (reviewer == null)
                return HttpNotFound();

            return View(reviewer);
        }
    }
}