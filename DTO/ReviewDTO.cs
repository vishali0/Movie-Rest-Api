using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.DTO
{
    public class ReviewDTO
    {
        public string ReviewDetails { get; set; }

        public int  MovieId { get; set; }

        public string MovieName { get; set; }

        //public string LanguageName { get; set; }

        
    }
}
