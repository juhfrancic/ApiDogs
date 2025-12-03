using ApiDogs.Models;
using ApiDogs.Models.DTO;
using ApiDogs.Repositories;
using System.Text.Json;

namespace ApiDogs.Service
{
    public class DogsService
    {
        public readonly HttpClient _client;
        public readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public readonly DogsRepository _dogsRepository;

        public DogsService(HttpClient client, DogsRepository dogsRepository)
        {
            _client = client;
            _dogsRepository = dogsRepository;
        }

        public async Task<DataApi> GetDogAsync(string id)
        {
            var response = await _client.GetAsync(id);

                var content = await response.Content.ReadAsStringAsync();
                var dogApiResponse = JsonSerializer.Deserialize<DataApi>(content, _options);
                await _dogsRepository.CreateDog(dogApiResponse);
                return dogApiResponse;

        }
    }
}
