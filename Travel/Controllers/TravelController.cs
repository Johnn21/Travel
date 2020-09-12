using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;
using Travel.ViewModels;


namespace Travel.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        private ApplicationDbContext _context;


        public TravelController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
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
                    filterContext.Result = new RedirectResult("/travel/acces");
                    return;
                }

                if (filterContext.Result is HttpUnauthorizedResult)
                {
                    filterContext.Result = new RedirectResult("/travel/acces");
                }
            }
        }


        //[Authorize]
     //   [AccessDeniedAuthorize(Roles = "CanAdmin,CanMakeReview,userRole")]
        public ViewResult Index()
        {
            var travel = _context.Travels.ToList();

            if (User.IsInRole("CanMakeReview"))
                return View("Index", travel);
            else if (User.IsInRole("CanAdmin"))
                return View("Index", travel);

            return View("Index", travel);

        }

        public ActionResult DetailsTravel(int id)
        {

            var travel = _context.Travels.SingleOrDefault(c => c.idTravel == id);

            if (travel == null)
                return HttpNotFound();

            return View(travel);
        }

        public ActionResult TravelReview(int id)
        {
             var travel = _context.Travels.SingleOrDefault(c => c.idTravel == id);

            if(travel == null)
            {
                return HttpNotFound();
            }

            var viewModel = new TravelReviewModel
            {
                Travel = travel,
                Reviews = _context.Reviews.ToList()
            };

            return View(viewModel);
        }
    }
}