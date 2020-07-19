using MovieRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Requests
{
    public class AddReviewRequest
    {
        public string Review { get; set; }

        
        public int  MovieId { get; set; }

       
        
    }
}
