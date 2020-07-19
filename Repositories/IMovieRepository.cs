using MovieRestApi.DTO;
using MovieRestApi.Models;
using MovieRestApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Repositories
{
    public interface IMovieRepository
    {
        public List<Language> AllLanguages();
        public bool AddLanguage(AddLanguageRequest request);

        public bool AddMovie(AddMovieRequest request);

        List<MovieDTO> GetMoviesByLanguageId(int LanguageId);

        public bool UpdateMovie(UpdateMovie request);
        List<ReviewDTO> GetReviewsByMovieId(int MovieId);
        public bool AddReview(AddReviewRequest request);


    }
}
