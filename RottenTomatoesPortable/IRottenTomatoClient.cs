using System.Collections.Generic;
using System.Threading.Tasks;
using RottenTomatoesPortable.Entities;

namespace RottenTomatoesPortable
{
    public interface IRottenTomatoClient
    {
        /// <summary>
        ///     Gets the API key.
        /// </summary>
        /// <value>
        ///     The API key.
        /// </value>
        string ApiKey { get; }

        /// <summary>
        /// Returns the top box office earning movies, sorted by most recent weekend gross ticket sales.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>
        /// The list of movies
        /// </returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetCurrentBoxOfficeAsync(int? limit = null, string country = null);

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
        Task<List<Movie>> GetMoviesInTheatresAsync(int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the opening movies async.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetOpeningMoviesAsync(int? limit = null, string country = null);

        /// <summary>
        /// Gets the upcoming movies.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetUpcomingMoviesAsync(int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the top DVD rentals.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetTopDvdRentalsAsync(int? limit = null, string country = null);

        /// <summary>
        /// Gets the DVD current releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetDvdCurrentReleasesAsync(int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the DVD new releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetDvdNewReleasesAsync(int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the DVD upcoming releases.
        /// </summary>
        /// <param name="limit">Limits the number of movies returned, default is 16</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="country">Provides localized data for the selected country (ISO 3166-1 alpha-2) if available. Otherwise, returns US data.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetDvdUpcomingReleasesAsync(int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the movie.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The specified movie</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<Movie> GetMovieAsync(string id);

        /// <summary>
        /// Gets the full movie cast .
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The list of cast members</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Cast>> GetFullMovieCastAsync(string id);

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
        Task<List<Review>> GetMovieReviewsAsync(string id, ReviewType reviewType = ReviewType.All, int? limit = null, int? pageNumber = null, string country = null);

        /// <summary>
        /// Gets the moview clips.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The list of clips</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Clip>> GetMoviewClipsAsync(string id);

        /// <summary>
        /// Gets the similar movies.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="limit">The limit.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.ArgumentNullException">id;ID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetSimilarMoviesAsync(string id, int? limit = null);

        /// <summary>
        /// Gets the movie by imdb id.
        /// </summary>
        /// <param name="imdbId">The imdb id.</param>
        /// <returns>The list of movies</returns>
        /// <exception cref="System.ArgumentNullException">imdbId;IMdbID cannot be null or empty</exception>
        /// <exception cref="System.NullReferenceException">Api Key cannot be null or empty</exception>
        Task<List<Movie>> GetMovieByImdbIdAsync(string imdbId);

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
        Task<SearchResponse> SearchMoviesAsync(string searchTerm, int? limit = null, int? pageNumber = null);
    }
}