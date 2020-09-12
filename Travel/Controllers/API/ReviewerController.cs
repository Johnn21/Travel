using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Travel.Models;

namespace Travel.Controllers.API
{
    public class ReviewerController : ApiController
    {
        private ApplicationDbContext _context;

        public ReviewerController()
        {
            _context = new ApplicationDbContext();
        }

        //get api/reviewer
        public IEnumerable<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        //get api/reviewer/1
        public Reviewer GetReviewer(int id)
        {
            var reviewer = _context.Reviewers.SingleOrDefault(c => c.reviewerId == id);

            if (reviewer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return reviewer;
        }

        //post /api/reviewer
        [HttpPost]
        public Reviewer CreateReviewer(Reviewer reviewer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Reviewers.Add(reviewer);
            _context.SaveChanges();

            return reviewer;
        }

        //put /api/reviewer/1
        [HttpPut]
        public void UpdateReviewer(int id, Reviewer reviewer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var reviewerInDb = _context.Reviewers.SingleOrDefault(c => c.reviewerId == id);

            if (reviewerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            reviewerInDb.userNameReviewer = reviewer.userNameReviewer;
            reviewerInDb.passwordReviewer = reviewer.passwordReviewer;
            reviewerInDb.emailAddressReviewer = reviewer.emailAddressReviewer;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteReviewer(int id)
        {
            var reviewerInDb = _context.Reviewers.SingleOrDefault(c => c.reviewerId == id);

            if (reviewerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Reviewers.Remove(reviewerInDb);
            _context.SaveChanges();

        }
    }
}
