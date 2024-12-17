using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {

        [HttpGet]
        public List<bizMeals> Get()
        {
            return new bizMeals().GetList();
        }
    }
}
