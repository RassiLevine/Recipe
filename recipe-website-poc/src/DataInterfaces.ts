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
    dateDraft: Date | string,
    datePublished: Date | null | string,
    dateArchived: Date | null | string,
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