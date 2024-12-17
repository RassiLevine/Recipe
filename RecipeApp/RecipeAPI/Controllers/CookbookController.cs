using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {

        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizCookbook Get(int id)
        {
            bizCookbook c = new bizCookbook();
            c.Load(id);
            return c;
        }
    }
}
