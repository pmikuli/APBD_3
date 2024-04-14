using Microsoft.AspNetCore.Mvc;
using REST_api.Interfaces;
using REST_api.Models;

namespace REST_api.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private IAnimalsService _animalsService;

        public AnimalsController(IAnimalsService animalsService)
        {
            _animalsService = animalsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAllAnimals()
        {
            return Ok();
        }


    }
}
