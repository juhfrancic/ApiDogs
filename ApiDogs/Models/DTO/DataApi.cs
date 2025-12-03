using System.Text.Json.Serialization;

namespace ApiDogs.Models.DTO
{
    public class DataApi
    {
        [JsonPropertyName("data")]
        public DogsApiResponse dog { get; set; }
    }
}
