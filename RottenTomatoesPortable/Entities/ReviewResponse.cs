﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace RottenTomatoesPortable.Entities
{
    public class ReviewResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("reviews")]
        public Review[] Reviews { get; set; }
    }
}
