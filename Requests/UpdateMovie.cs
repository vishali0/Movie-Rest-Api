using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Requests
{
    public class UpdateMovie: AddMovieRequest
    {
        public int Id { get; set; }
    }
}
