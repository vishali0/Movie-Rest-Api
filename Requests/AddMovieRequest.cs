using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Requests
{
    public class AddMovieRequest
    {
        public string Name { get; set; }

        public int LanguageId { get; set; }
    }
}
