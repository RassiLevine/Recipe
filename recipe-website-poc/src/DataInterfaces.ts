export interface ICuisine {
    cuisineId: number,
    cuisineType: string,
    errorMessage: string;
}
export interface IRecipe {
    recipeId: number,
    cuisineId: number,
    staffId: number,
    user: string,
    recipeName: string,
    calories: number,
    dateDraft: Date,
    datePublished: Date
    dateArchived: Date,
    recipeStatus: string,
    recipePic: string,
    isVegan: string,
    numIngredients: number,
    errorMessage: string;
}

export interface IStaff {
    staffId: number,
    staffFirstName: string,
    staffLastName: string,
    userName: string,
    errorMessage: string;
}