





namespace AllSpice.Services
{
    public class RecipesService
    {
        private readonly RecipesRepository _recipesRepository;

        public RecipesService(RecipesRepository recipesRepository)
        {
            _recipesRepository = recipesRepository;
        }

        internal Recipe CreateRecipe(Recipe recipeData)
        {
            Recipe recipe = _recipesRepository.CreateRecipe(recipeData);
            return recipe;
        }

        internal Recipe GetRecipeById(int recipeId)
        {
            Recipe recipe = _recipesRepository.GetRecipeById(recipeId);
            return recipe;
        }

        internal List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = _recipesRepository.GetRecipes();
            return recipes;
        }

        internal Recipe UpdateRecipe(int recipeId, Recipe recipeData)
        {
            Recipe originalRecipe = GetRecipeById(recipeId);

            originalRecipe.Instructions = recipeData.Instructions ?? originalRecipe.Instructions;

            return originalRecipe;



        }
    }
}