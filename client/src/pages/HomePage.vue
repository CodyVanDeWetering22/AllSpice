<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-12">
        <img class="bgImg mt-3"
          src="https://media.istockphoto.com/id/1390064458/photo/vegetables-herbs-and-spices-copy-space.webp?b=1&s=170667a&w=0&k=20&c=bGTHLOs2TTeE-W1sH-gsr8ZXBIcMeTd3sF65Vwpq1DQ="
          alt="Snow">
        <div class="centered text-center">
          <h1>All-Spice</h1>
          <p class="fs-4">Cherish Your Family</p>
          <p class="fs-4">And Their Cooking</p>

          <div class="row">
            <div class="col-12 d-flex">

              <div class="mb-1">
                <button class="btn btn-primary">Home</button>
              </div>

              <div class="mb-1 mx-1">
                <button class="btn btn-primary">Home</button>
              </div>

              <div class="mb-1">
                <button class="btn btn-primary">Home</button>
              </div>


            </div>
          </div>
        </div>
      </div>




    </div>
  </div>

  <div class="container-fluid">
    <div class="row text-center mt-2">
      <div v-for="recipe in  recipes " :key="recipe.id" class="col-12 col-md-4 ps-5">
        <RecipeCard :recipeProp="recipe" />
      </div>
    </div>
  </div>
</template>

<script>
import { computed, onMounted } from 'vue';
import Pop from '../utils/Pop.js';
import { recipesService } from '../services/RecipesService.js'
import { AppState } from '../AppState.js'
import RecipeCard from '../components/RecipeCard.vue';



export default {
  setup() {
    onMounted(() => {
      getRecipes();
    });
    async function getRecipes() {
      try {
        await recipesService.getRecipes();
      }
      catch (error) {
        Pop.error(error);
      }
    }
    return {
      recipes: computed(() => AppState.recipes),
      recipeImg: computed(() => `url(${props.recipeProp.img})`)

    };
  },
  components: { RecipeCard }
}
</script>

<style scoped lang="scss">
.centered {
  position: absolute;
  top: 35%;
  left: 50%;
  transform: translate(-50%, -50%);
  background-position: center;

}

.center {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}

.recipeImg {
  position: relative;
  position: absolute;
}


.bgImg {
  height: 25rem;
  width: 100%;
}

.imgCard {
  height: 25rem;
  width: 25rem;
}
</style>../services/RecipesService.js
