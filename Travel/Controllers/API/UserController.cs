using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Travel.Models;

namespace Travel.Controllers.API
{
    public class UserController : ApiController
    {
        private ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        //get api/user
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        //get api/user/1
        public User GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.idUser == id);

            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return user;
        }

        //post /api/user
        [HttpPost]
        public User CreateUser(User user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        //put /api/user/1
        [HttpPut]
        public void UpdateUser(int id,User user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = _context.Users.SingleOrDefault(c => c.idUser == id);

            if(userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            userInDb.firstNameUser = user.firstNameUser;
            userInDb.lastNameUser = user.lastNameUser;
            userInDb.userNameUser = user.userNameUser;
            userInDb.passwordUser = user.passwordUser;
            userInDb.phoneUser = user.phoneUser;
            userInDb.emailAddressUser = user.emailAddressUser;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            var userInDb = _context.Users.SingleOrDefault(c => c.idUser == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Users.Remove(userInDb);
            _context.SaveChanges();

        }


    }
}
