using Microsoft.EntityFrameworkCore;
using MovieRestApi.DTO;
using MovieRestApi.Models;
using MovieRestApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Repositories
{
    public class MovieRepository:IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        private int languageId;

        public MovieRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public bool AddLanguage(AddLanguageRequest request)
        {
            if (request != null)
            {
                Language language= new Language();
                language.LanguageName = request.Name;
                

                _db.Languages.Add(language);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        

        public List<Language> AllLanguages()
        {
            return _db.Languages.ToList();
        }

        public bool AddMovie(AddMovieRequest request)
        {
            if (request != null)
            {
                Movie movie = new Movie();
                movie.MovieName = request.Name;
                movie.LanguageId = request.LanguageId;

                _db.Movies.Add(movie);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<MovieDTO> GetMoviesByLanguageId(int LanguageId)
        {
            List<MovieDTO> MoviesByLanguage = new List<MovieDTO>();
            

            List<Movie> movies = _db.Movies.Include("Language").Where(a => a.LanguageId == LanguageId).ToList();
            foreach (var movie in movies)
            {
                MoviesByLanguage.Add(new MovieDTO
                {
                    MovieName = movie.MovieName,                    
                    LanguageId = LanguageId,
                    LanguageName=movie.Language.LanguageName

                });
            }
            return MoviesByLanguage;


        }

        public List<ReviewDTO> GetReviewsByMovieId(int MovieId)
        {
            List<ReviewDTO> ReviewsByMovie = new List<ReviewDTO>();

            List<Review> reviews = _db.Reviews.Include("Movie").Where(a => a.MovieId == MovieId).ToList();
            foreach (var review in reviews)
            {
                ReviewsByMovie.Add(new ReviewDTO
                {
                    ReviewDetails=review.ReviewDetails,
                    MovieId=MovieId,
                    MovieName=review.Movie.MovieName
                    

                });
            }

            return ReviewsByMovie;


        }

        public bool AddReview(AddReviewRequest request)
        {
            if (request != null)
            {
                Review review = new Review();
                review.ReviewDetails = request.Review;
                review.MovieId = request.MovieId;
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateMovie(UpdateMovie request)
        {
            if (request != null)
            {
                var movie = _db.Movies.Where(a => a.MovieId == request.Id).FirstOrDefault();
                if (movie != null)
                {

                    movie.MovieName = string.IsNullOrEmpty(request.Name) ? movie.MovieName : request.Name;
                    //grade.Section = string.IsNullOrEmpty(request.Section) ? grade.Section : request.Section;

                    /*if (request.Name != null)
                    {
                        movie.MovieName = request.Name;
                    }*/
                    
                    _db.SaveChanges();

                    return true;
                }
                return false;
            }
            return false;
        }


    }
}



/*var movies = from movieList in _db.Movies
                         where movieList.Language.LanguageId == LanguageId
                         select movieList;

            foreach (var movie in movies)
            {
                MoviesByLanguage.Add(movie);
            }


            return MoviesByLanguage;
var reviews = from reviewList in _db.Reviews
                         where reviewList.Movie.MovieId == MovieId
                         select reviewList;
            foreach (var review in reviews)
            {
                ReviewsByLanguage.Add(review);
            }
 */
