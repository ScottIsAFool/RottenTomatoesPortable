using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RottenTomatoesPortable.Entities;

namespace RottenTomatoesPortable
{
    /// <summary>
    /// Client for accessing the Rotten Tomato API
    /// </summary>
    public class RottenTomatoClient : IRottenTomatoClient
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
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>
        /// The list of movies
        /// </returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetCurrentBoxOfficeAsync(int? limit = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();
            
            AddStandardParamsToDict(dict, limit, country: country);

            var url = GetUrl("lists/movies/box_office.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the movies in theatres.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>
        /// The list of movies
        /// </returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetMoviesInTheatresAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var url = GetUrl("lists/movies/in_theaters.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the opening movies async.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetOpeningMoviesAsync(int? limit = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, country: country);

            var url = GetUrl("lists/movies/opening.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the upcoming movies.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetUpcomingMoviesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var url = GetUrl("lists/movies/upcoming.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        #endregion

        #region DVD Lists

        /// <summary>
        /// Gets the top DVD rentals.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetTopDvdRentalsAsync(int? limit = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, country: country);

            var url = GetUrl("lists/dvds/top_rentals.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the DVD current releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetDvdCurrentReleasesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var url = GetUrl("lists/dvds/current_releases.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the DVD new releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetDvdNewReleasesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var url = GetUrl("lists/dvds/new_releases.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the DVD upcoming releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetDvdUpcomingReleasesAsync(int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var url = GetUrl("lists/dvds/upcoming.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        #endregion

        #region Movie Info

        /// <summary>
        /// Gets the movie.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The specified movie</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<Movie> GetMovieAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "ID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            var path = string.Format("movies/{0}.json", id);

            var url = GetUrl(path, dict);

            var response = await MakeRequestAsync<Movie>(url);

            return response;
        }

        /// <summary>
        /// Gets the full movie cast .
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The list of cast members</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Cast>> GetFullMovieCastAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "ID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            var path = string.Format("movies/{0}/cast.json", id);

            var url = GetUrl(path, dict);

            var response = await MakeRequestAsync<CastResponse>(url);

            return response.Cast.ToList();
        }

        /// <summary>
        /// Gets the movie reviews.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="reviewType">Type of the review.</param>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of reviews</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Review>> GetMovieReviewsAsync(string id, ReviewType reviewType = ReviewType.All, int? limit = null, int? pageNumber = null, string country = null)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "ID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();
            dict.Add("review_type", reviewType.GetDescription());

            AddStandardParamsToDict(dict, limit, pageNumber, country);

            var path = string.Format("movies/{0}/reviews.json", id);

            var url = GetUrl(path, dict);

            var response = await MakeRequestAsync<ReviewResponse>(url);

            return response.Reviews.ToList();
        }

        /// <summary>
        /// Gets the moview clips.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The list of clips</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Clip>> GetMoviewClipsAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "ID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();

            var path = string.Format("movies/{0}/clips.json", id);

            var url = GetUrl(path, dict);

            var response = await MakeRequestAsync<ClipsResponse>(url);

            return response.Clips.ToList();
        }

        /// <summary>
        /// Gets the similar movies.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="limit">The limit.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetSimilarMoviesAsync(string id, int? limit = null)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id", "ID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();
            AddStandardParamsToDict(dict, limit);

            var path = string.Format("movies/{0}/similar.json", id);

            var url = GetUrl(path, dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        /// <summary>
        /// Gets the movie by imdb id.
        /// </summary>
        /// <param name="imdbId">The imdb id.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.ArgumentNullException">imdbId;IMdbID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<List<Movie>> GetMovieByImdbIdAsync(string imdbId)
        {
            if (string.IsNullOrEmpty(imdbId))
            {
                throw new ArgumentNullException("imdbId", "IMdbID cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();
            dict.Add("id", imdbId);
            dict.Add("type", "imdb");

            var url = GetUrl("movie_alias.json", dict);

            var response = await MakeRequestAsync<MovieResponse>(url);

            return response.Movies.ToList();
        }

        #endregion

        #region Search Movies

        /// <summary>
        /// Searches the movies async.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <returns>
        /// The details of the search (including total search results)
        /// </returns>
        /// <exception cref="System.ArgumentNullException">searchTerm;Search term cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        public async Task<SearchResponse> SearchMoviesAsync(string searchTerm, int? limit = null, int? pageNumber = null)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                throw new ArgumentNullException("searchTerm", "Search term cannot be null or empty");
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new NullReferenceException("Api Key cannot be null or empty");
            }

            var dict = CreateDefaultParameters();
            dict.Add("q", searchTerm);

            AddStandardParamsToDict(dict, limit, pageNumber);

            var url = GetUrl("movies.json", dict);

            var response = await MakeRequestAsync<SearchResponse>(url);
            return response;
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

        private void AddStandardParamsToDict(Dictionary<string, string> dict, int? limit = null, int? pageNumber = null, string country = null)
        {
            if (limit.HasValue)
            {
                dict.Add("limit", limit.Value.ToString());
                dict.Add("page_limit", limit.Value.ToString());
            }

            if (pageNumber.HasValue)
            {
                dict.Add("page", pageNumber.Value.ToString());
            }

            if (!string.IsNullOrEmpty(country))
            {
                dict.Add("country", country);
            }
        }

        #endregion
    }
}