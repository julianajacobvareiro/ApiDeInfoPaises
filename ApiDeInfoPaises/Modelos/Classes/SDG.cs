using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class SDG
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
    }

}