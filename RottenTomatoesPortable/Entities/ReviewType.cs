using RottenTomatoesPortable.Attributes;

namespace RottenTomatoesPortable.Entities
{
    public enum ReviewType
    {
        /// <summary>
        /// All reviews
        /// </summary>
        [Description("all")]
        All,

        /// <summary>
        /// Shows all the Rotten Tomatoes designated top critics
        /// </summary>
        [Description("top_critic")]
        TopCritic,

        /// <summary>
        /// Reviews given on the DVD of the movie
        /// </summary>
        [Description("dvd")]
        Dvd
    }
}