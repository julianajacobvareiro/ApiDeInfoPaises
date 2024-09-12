using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class HNL
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

}