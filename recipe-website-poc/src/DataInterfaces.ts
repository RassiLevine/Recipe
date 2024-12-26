export interface ICuisine {
    cuisineId: number,
    cuisineType: string
}
export interface IRecipe {
    recipeId: number,
    cuisineId: number,
    staffId: number,
    user: string,
    recipeName: string,
    calories: number,
    dateDraft: string,
    datePublished: string
    dateArchived: string,
    recipeStatus: string,
    recipePic: string,
    isVegan: string,
    numIngredients: number
}