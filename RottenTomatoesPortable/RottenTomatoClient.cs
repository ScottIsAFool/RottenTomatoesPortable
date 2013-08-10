using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RottenTomatoesPortable.Entities;

namespace RottenTomatoesPortable
{
    public class RottenTomatoClient
    {
        #region Private Fields
        private const string BaseUrl = "http://api.rottentomatoes.com/api/public/v1.0/";

        /// <summary>
        ///     The HTTP client
        /// </summary>
        private readonly HttpClient _httpClient;

        #endregion

        #region Constructors

        public RottenTomatoClient(string apiKey)
            : this(new HttpClientHandler {AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip}, apiKey)
        {
        }

        public RottenTomatoClient(HttpMessageHandler handler, string apiKey)
        {
            _httpClient = new HttpClient(handler);
            ApiKey = apiKey;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the API key.
        /// </summary>
        /// <value>
        ///     The API key.
        /// </value>
        public string ApiKey { get; private set; }

        #endregion

        #region Public Methods

        #region Movie Lists

        /// <summary>
        /// Returns the top box office earning movies, sorted by most recent weekend gross ticket sales.
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="country">The country.</param>
        /// <returns>The list of movies</returns>
        public async Task<List<Movie>> GetCurrentBoxOfficeAsync(int? limit = null, string country = null)
        {
            // lists/movies/box_office.json
            return new List<Movie>();
        }

        /// <summary>
        /// Gets the movies in theatres.
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">The country.</param>
        /// <returns>The list of movies</returns>
        public async Task<List<Movie>> GetMoviesInTheatresAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            // lists/movies/in_theaters.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetOpeningMoviesAsync(int? limit = null, string country = null)
        {
            // lists/movies/opening.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetUpcomingMoviesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            // lists/movies/upcoming.json
            return new List<Movie>();
        }

        #endregion

        #region DVD Lists

        public async Task<List<Movie>> GetTopDvdRentalsAsync(int? limit = null, string country = null)
        {
            // lists/dvds/top_rentals.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetDvdCurrentReleasesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            // lists/dvds/current_releases.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetDvdNewReleasesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            // lists/dvds/new_releases.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetDvdUpcomingReleases(int? limit = null, int? pageNumber = null, string country = null)
        {
            // lists/dvds/upcoming.json
            return new List<Movie>();
        }

        #endregion

        #region Movie Info
        
        public async Task<Movie> GetMovieAsync(string id)
        {
            // movies/{id}.json
            return new Movie();
        }

        public async Task<List<Cast>> GetFullMovieCastAsync(string id)
        {
            // movies/{id}/cast.json
            return new List<Cast>();
        }

        public async Task<List<Review>> GetMovieReviewsAsync(string id, ReviewType reviewType = ReviewType.All, int? pageLimit = null, int? pageNumber = null, string country = null)
        {
            // movies/{id}/reviews.json
            return new List<Review>();
        }

        public async Task<List<Clip>> GetMoviewClipsAsync(string id)
        {
            // movies/{id}/clips.json
            return new List<Clip>();
        }

        public async Task<List<Movie>> GetSimilarMoviesAsync(string id, int? limit = null)
        {
            // movies/{id}/similar.json
            return new List<Movie>();
        }

        public async Task<List<Movie>> GetMovieByImdbIdAsync(string imdbId)
        {
            // movie_alias.json
            return new List<Movie>();
        }

        #endregion

        #region Search Movies

        public async Task<SearchResponse> SearchMoviesAsync(string searchTerm, int? pageLimit = null, int? pageNumber = null)
        {
            // movies.json
            return new SearchResponse();
        }

        #endregion

        #endregion

        #region Private Methods

        private Dictionary<string, string> CreateDefaultParameters()
        {
            var dict = new Dictionary<string, string> {{"apikey", ApiKey}};

            return dict;
        }

        private string GetUrl(string path, Dictionary<string, string> parameters)
        {
            return string.Format("{0}{1}{2}", BaseUrl, path, parameters.ToUrlParams());
        }

        private async Task<T> MakeRequestAsync<T>(string url)
        {
            var response = await _httpClient.GetStringAsync(url);

            var responseItem = JsonConvert.DeserializeObject<T>(response);

            return responseItem;
        }

        #endregion
    }
}