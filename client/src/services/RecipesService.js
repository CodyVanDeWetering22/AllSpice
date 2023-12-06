
import { Recipe } from "../models/Recipe.js"
import { logger } from "../utils/Logger.js"
import { api } from "./AxiosService.js"
import { AppState } from "../AppState.js"

class RecipesService {
    async getRecipes() {
        const res = await api.get('api/recipes')
        logger.log(res.data)
        const newRecipes = res.data.map(pojo => new Recipe(pojo))
        AppState.recipes = newRecipes
    }
}

export const recipesService = new RecipesService()