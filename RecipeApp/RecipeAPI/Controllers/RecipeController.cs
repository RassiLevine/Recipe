using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }
        [HttpGet("colors")]
        public List<bizCuisine> GetCuisine()
        {
            return new bizCuisine().GetList();
        }
        [HttpGet("staff")]
        public List<bizStaff> GetStaff()
        {
            return new bizStaff().GetList();
        }

        [HttpGet("{id:int:min(0)}")]
        public bizRecipe Get(int id)
        {
            bizRecipe r = new bizRecipe();
            r.Load(id);
            return r;
        }

        [HttpGet("bycookbookid/{cookbookid:int:min(1)}")]
        public List<bizRecipe> GetBasedOnCookbook(int cookbookid)
        {
            // return new bizRecipe().ListRecipeBasedOnCookbook(cookbookid);
            bizRecipe r = new bizRecipe();
            return r.ListRecipeBasedOnCookbook(cookbookid);
        }

        [HttpGet("bycuisineid/{cuisineid:int:min(1)}")]
        public List<bizRecipe> GetBasedOnCuisine(int cuisineid)
        {
            // return new bizRecipe().ListRecipeBasedOnCookbook(cookbookid);
            bizRecipe r = new bizRecipe();
            return r.ListRecipeBaseOnCuisine(cuisineid);
        }
        [HttpPost]
        public IActionResult Post([FromForm] bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new { message = "recipes saved", recipeid = recipe.RecipeId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                bizRecipe r = new();
                r.Delete(id);
                return Ok(new { message = "Recipe Deleted" });
            }
            catch(Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}
