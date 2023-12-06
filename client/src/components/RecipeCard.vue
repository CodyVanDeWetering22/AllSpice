<template>
    <div class="container-fluid my-5">
        <div class="row cardImg text-light">

            <div class="d-flex justify-content-start">
                <div class="mb-5">
                    <p class="textBg fs-5 p-1 mt-2">{{ recipeProp.category }}</p>
                </div>
            </div>

            <div class="d-flex align-items-center justify-content-center">
                <p class="textBg fs-4"> {{ recipeProp.title }}</p>
            </div>
        </div>
    </div>
</template>


<script>
import { computed } from 'vue';
import { Recipe } from '../models/Recipe.js';
export default {
    props: { recipeProp: { type: Recipe, required: true } },
    setup(props) {
        return {
            recipeImg: computed(() => `url(${props.recipeProp.img})`)
        }
    }
};
</script>


<style lang="scss" scoped>
.cardImg {
    background-image: v-bind(recipeImg);
    height: 50vh;
    width: 100%;
    background-position: center;
    background-size: cover;
    border-radius: 5px;
}

.textBg {
    background-color: rgba(0, 0, 0, 0.66);
    backdrop-filter: blur(10px);
    border-radius: 3px;
}
</style>