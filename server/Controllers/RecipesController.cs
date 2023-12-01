

namespace AllSpice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {

        private readonly Auth0Provider _auth0Provider;
        private readonly RecipesService _recipesService;

        public RecipesController(Auth0Provider auth0Provider, RecipesService recipesService)
        {
            _auth0Provider = auth0Provider;
            _recipesService = recipesService;
        }



        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Recipe>> CreateRecpie([FromBody] Recipe recipeData)
        {
            try
            {
                Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
                recipeData.CreatorId = userInfo.Id;
                Recipe recipe = _recipesService.CreateRecipe(recipeData);
                return Ok(recipe);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<Recipe>> GetRecipes()
        {

            try
            {
                List<Recipe> recipes = _recipesService.GetRecipes();
                return Ok(recipes);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpGet("{recipeId}")]
        public ActionResult<Recipe> GetRecipeById(int recipeId)
        {
            try
            {
                Recipe recipe = _recipesService.GetRecipeById(recipeId);
                return recipe;
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


        [HttpPut("{recipeId}")]
        public ActionResult<Recipe> UpdateRecipe(int recipeId, [FromBody] Recipe recipeData)
        {
            try
            {
                Recipe recipe = _recipesService.UpdateRecipe(recipeId, recipeData);
                return Ok(recipe);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }

}