





namespace AllSpice.Repositories
{
    public class RecipesRepository
    {
        private readonly IDbConnection _db;

        public RecipesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Recipe CreateRecipe(Recipe recipeData)
        {
            string sql = @"
            INSERT INTO 
            recipe(title, instructions, img, category, creatorId )
            VALUES(@Title, @Instructions, @Img, @Category, @CreatorId);

            SELECT 
            res.*,
            acc.*
            FROM recipe res
            JOIN accounts acc ON res.creatorId = acc.id
            WHERE res.id = LAST_INSERT_ID();";

            Recipe recipe = _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
            {
                recipe.Creator = profile;
                return recipe;
            }, recipeData).FirstOrDefault();
            return recipe;
        }

        internal Recipe GetRecipeById(int recipeId)
        {
            string sql = @"
            SELECT 
            res.*,
            acc.*
            FROM recipe res 
            JOIN accounts acc ON res.creatorId = acc.id         
            WHERE res.id = @recipeId;";

            Recipe recipe = _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
            {
                recipe.Creator = profile;
                return recipe;
            }, new { recipeId }).FirstOrDefault();
            return recipe;
        }

        internal List<Recipe> GetRecipes()
        {
            string sql = @" 
            SELECT
            res.*,
            acc.*
            FROM recipe res
            JOIN accounts acc ON res.creatorId = acc.id;";

            List<Recipe> recipes = _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
            {
                recipe.Creator = profile;
                return recipe;
            }).ToList();
            return recipes;



        }

        internal void UpdateRecipe(Recipe originalRecipe)
        {
            string sql = @"
            UPDATE recipe
            SET
            instructions = @Instructions
            
            ;";

            _db.Execute(sql, originalRecipe);
        }
    }
}