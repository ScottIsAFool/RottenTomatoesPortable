using Newtonsoft.Json;
using PropertyChanged;

namespace RottenTomatoesPortable.Entities
{
    [ImplementPropertyChanged]
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        [JsonProperty("mpaa_rating")]
        public string MpaaRating { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("critics_consensus")]
        public string CriticsConsensus { get; set; }

        [JsonProperty("release_dates")]
        public ReleaseDates ReleaseDates { get; set; }

        [JsonProperty("ratings")]
        public Ratings Ratings { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("posters")]
        public Posters Posters { get; set; }

        [JsonProperty("abridged_cast")]
        public Cast[] Cast { get; set; }

        [JsonProperty("abridged_directors")]
        public Director[] Directors { get; set; }

        [JsonProperty("studio")]
        public string Studio { get; set; }

        [JsonProperty("alternate_ids")]
        public AlternateIds AlternateIds { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}