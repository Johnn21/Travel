using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        private ApplicationDbContext _context;


        public UserController()
        {
           
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            User user = new User();

            return View("New",user); 
        }

        public ActionResult Redirect()
        {
            return RedirectToAction("Index", "User/New");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("New", user);
            }


            if (user.idUser == 0)
                _context.Users.Add(user);
            else
            {
                var userInDb = _context.Users.Single(c => c.idUser == user.idUser);

                 userInDb.firstNameUser = user.firstNameUser;
                 userInDb.lastNameUser = user.lastNameUser;
                 userInDb.userNameUser = user.userNameUser;
                 userInDb.passwordUser = user.passwordUser;
                 userInDb.emailAddressUser = user.emailAddressUser;
                 userInDb.phoneUser = user.phoneUser;
                
          
            }

            _context.SaveChanges();

            return RedirectToAction("Index","User");
        }

        public ActionResult Edit(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.idUser == id);

            if (user == null)
                return HttpNotFound();

            return View("New",user);

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

        //[Authorize(Roles = "CanMakeReview")]
        // [Authorize]
        [AccessDeniedAuthorize(Roles = "CanAdmin,CanMakeReview,userRole")]
      
        public ViewResult Index()
        {

            List<User> user = _context.Users.ToList();

            if (User.IsInRole("CanMakeReview"))
                return View("UserDetailsList", user);
            else if (User.IsInRole("CanAdmin"))
                return View("Index", user);

                return View("UserDetailsList", user);
        
         //   return View(user);
        }

        public ActionResult Details(int id)
        {

            var user = _context.Users.SingleOrDefault(c => c.idUser == id);

            if (user == null)
                return HttpNotFound();

            return View(user);
        }
    }
}