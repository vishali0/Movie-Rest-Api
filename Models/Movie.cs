using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRestApi.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public Language Language { get; set; }

        public int LanguageId { get; internal set; }

        //public string LanguageName { get; internal set; }
        //public object LanguageId { get; internal set; }
    }
}
