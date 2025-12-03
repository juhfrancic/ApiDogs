using ApiDogs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogApiController : ControllerBase
    {
        public DogsService _canilService;

        public DogApiController(DogsService canilService)
        {
            _canilService = canilService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogAsync(string id)
        {
            var dog = await _canilService.GetDogAsync(id);
            if (dog is null)
                return NotFound();

            return Ok(dog);
        }
    }
}
