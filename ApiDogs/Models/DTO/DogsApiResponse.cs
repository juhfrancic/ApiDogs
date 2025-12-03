using System.Text.Json.Serialization;

namespace ApiDogs.Models.DTO
{
    public class DogsApiResponse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("type")]
        public string DogType { get; set; }
    }
}
