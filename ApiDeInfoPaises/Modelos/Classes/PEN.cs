using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class PEN
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

}