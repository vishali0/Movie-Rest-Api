using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewDetails { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; internal set; }

        //public string MovieName { get; internal set; }

        //public Movie MovieId { get; internal set; }
    }
}
