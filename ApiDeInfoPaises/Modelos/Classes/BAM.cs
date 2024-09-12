using System.Text.Json.Serialization; 
namespace countryproj{ 

    public class BAM
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
    }

}