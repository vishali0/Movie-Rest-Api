using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRestApi.Repositories;
using System.Runtime.CompilerServices;
using MovieRestApi.Requests;

namespace MovieRestApi.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository repository;

        public MovieController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("Languages")]
        public IActionResult Languages()
        {
            return Ok(repository.AllLanguages());
        }

        [HttpPost("AddLanguage")]
        public IActionResult AddLanguage(AddLanguageRequest data)
        {
            return Ok(repository.AddLanguage(data));
        }

        

        [HttpGet("Movies/{LanguageId}")]
        public IActionResult Movies(int LanguageId)
        {
            return Ok(repository.GetMoviesByLanguageId(LanguageId));
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie(AddMovieRequest data)
        {
            return Ok(repository.AddMovie(data));
        }


        [HttpPut("UpdateMovie")]
        public IActionResult UpdateGrade(UpdateMovie data)
        {
            return Ok(repository.UpdateMovie(data));
        }


        [HttpGet("Reviews/{MovieId}")]
        public IActionResult Reviews(int MovieId)
        {
            return Ok(repository.GetReviewsByMovieId(MovieId));
        }

        [HttpPost("AddReview")]
        public IActionResult AddReview(AddReviewRequest data)
        {
            return Ok(repository.AddReview(data));
        }


    }
}
