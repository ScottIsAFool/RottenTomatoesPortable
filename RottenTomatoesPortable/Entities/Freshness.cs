using RottenTomatoesPortable.Attributes;

namespace RottenTomatoesPortable.Entities
{
    public enum Freshness
    {
        [Description("fresh")]
        Fresh,
        
        [Description("rotten")]
        Rotten
    }
}