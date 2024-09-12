using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class CoatOfArms
    {
        [JsonPropertyName("png")]
        public string png { get; set; }

        [JsonPropertyName("svg")]
        public string svg { get; set; }
    }

}