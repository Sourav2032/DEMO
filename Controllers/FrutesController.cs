using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrutesController : ControllerBase
    {
        public List<string> Frutes = new List<string>()
        {
            "apple",
            "mango",
            "banana",
            "cherry",
            "grapes"

        };
        [HttpGet]
        public List<string> getFrutes()
        {
            return Frutes;
        }

        [HttpGet("{id}")]
        public string getFrutesByIndex(int id)
        {
            return Frutes.ElementAt(id);
        }


    }
}
