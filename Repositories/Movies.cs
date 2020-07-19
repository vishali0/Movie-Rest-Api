using MovieRestApi.Models;

namespace MovieRestApi.Repositories
{
    internal class Movies : Movie
    {
        public string MovieName { get; set; }
        public int Id { get; set; }
        public object LanguageId { get; set; }
    }
}