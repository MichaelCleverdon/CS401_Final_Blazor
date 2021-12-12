using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CS401_Final_Blazor.Data
{
    public class RandomPictureModel
    {
        [JsonPropertyName("urls")]
        public UrlObject Urls { get; set; }
        [JsonPropertyName("user")]
        public UserObject User { get; set; }
    }

    public class UrlObject
    {
        public UrlObject()
        {

        }
        [JsonPropertyName("raw")]
        public Uri Raw { get; set; }
        [JsonPropertyName("full")]
        public Uri Full { get; set; }
        [JsonPropertyName("regular")]
        public Uri Regular { get; set; }
        [JsonPropertyName("small")]
        public Uri Small { get; set; }
        [JsonPropertyName("thumb")]
        public Uri Thumb { get; set; }

    }

    public class UserObject
    {
        public UserObject()
        {

        }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("links")]
        public UnsplashLinks Links { get; set; }

    }

    public class UnsplashLinks
    {
        [JsonPropertyName("self")]
        public Uri Self { get; set; }
        [JsonPropertyName("html")]
        public Uri Profile { get; set; }
        [JsonPropertyName("photos")]
        public Uri Photos { get; set; }
    }
}
