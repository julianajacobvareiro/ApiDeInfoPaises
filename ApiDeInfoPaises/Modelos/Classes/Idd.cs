using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace countryproj{ 

    public class Idd
    {
        [JsonPropertyName("root")]
        public string root { get; set; }

        [JsonPropertyName("suffixes")]
        public List<string> suffixes { get; set; }
    }

}