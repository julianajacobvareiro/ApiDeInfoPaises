using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace countryproj{ 

    public class CapitalInfo
    {
        [JsonPropertyName("latlng")]
        public List<double?> latlng { get; set; }
    }

}