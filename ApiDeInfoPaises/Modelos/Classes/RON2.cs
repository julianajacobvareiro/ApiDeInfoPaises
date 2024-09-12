using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class RON2
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

}