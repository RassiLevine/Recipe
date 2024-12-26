using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        [HttpGet]
        public List<bizCuisine> Get()
        {
            return new bizCuisine().GetList();
        }
    }
}
