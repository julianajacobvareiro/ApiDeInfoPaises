using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class PostalCode
    {
        [JsonPropertyName("format")]
        public string format { get; set; }

        [JsonPropertyName("regex")]
        public string regex { get; set; }
    }

}