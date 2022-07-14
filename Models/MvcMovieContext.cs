namespace MvcMovie.Models
{
    internal class MvcMovieContext
    {
        private object value;

        public MvcMovieContext(object value)
        {
            this.value = value;
        }

        internal static object AddRange(Movie movie1, Movie movie2)
        {
            throw new NotImplementedException();
        }
    }
}