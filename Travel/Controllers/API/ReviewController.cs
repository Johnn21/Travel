using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Travel.Models;

namespace Travel.Controllers.API
{
    public class ReviewController : ApiController
    {
        private ApplicationDbContext _context;

        public ReviewController()
        {
            _context = new ApplicationDbContext();
        }

        //get api/review
        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        //get api/review/1
        public Review GetReview(int id)
        {
            var review = _context.Reviews.SingleOrDefault(c => c.idReview == id);

            if (review == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return review;
        }

        //post /api/review
        [HttpPost]
        public Review CreateReview(Review review)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Reviews.Add(review);
            _context.SaveChanges();

            return review;
        }

        //put /api/reviewer/1
        [HttpPut]
        public void UpdateReview(int id, Review review)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var reviewInDb = _context.Reviews.SingleOrDefault(c => c.idReview == id);

            if (reviewInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            reviewInDb.locationReview = review.locationReview;
            reviewInDb.nameReview = review.nameReview;
            reviewInDb.overallRating = review.overallRating;
            reviewInDb.relevanceReview = review.relevanceReview;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteReview(int id)
        {
            var reviewInDb = _context.Reviews.SingleOrDefault(c => c.idReview == id);

            if (reviewInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Reviews.Remove(reviewInDb);
            _context.SaveChanges();

        }
    }
}
