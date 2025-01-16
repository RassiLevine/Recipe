import { createAPI, getUserStore } from "@rassilevine/reactutils";
import { ICuisine, IRecipe, IStaff } from "./DataInterfaces";
import { FieldValues } from "react-hook-form";
let baseurl = import.meta.env.VITE_API_URL;

function api() {
    const sessionkey = getUserStore(baseurl).getState().sessionKey;
    return createAPI(baseurl, sessionkey);
}
function formatRecipeDate(recipe: IRecipe): IRecipe {
    return {
        ...recipe,
        dateDraft: formatDate(recipe.dateDraft),
        datePublished: formatDate(recipe.datePublished),
        dateArchived: formatDate(recipe.dateArchived)
    };
}

function formatDate(date: Date | string | null): string {
    if (!date) return "";
    const d = new Date(date);
    const month = ("0" + (d.getMonth() + 1)).slice(-2);
    const day = ("0" + d.getDate()).slice(-2);
    return `${d.getFullYear()}-${month}-${day}`;
}
export async function fetchCuisine() {
    return await api().fetchData<ICuisine[]>("Cuisine")
}
export async function fetchRecipeByCuisine(cuisineId: number) {
    console.log(baseurl + "Recipe/bycuisineid/" + cuisineId)
    const recipe = await api().fetchData<IRecipe[]>("Recipe/bycuisineid/" + cuisineId)
    return recipe.map(formatRecipeDate);
}

export async function fetchStaff() {
    return await api().fetchData<IStaff[]>("Recipe/Staff");
}
export async function PostRecipe(form: FieldValues) {
    const recipe = await api().PostData<IRecipe>("recipe", form);
    return formatRecipeDate(recipe);
}

export async function DeleteRecipe(recipeId: number) {
    const recipe = await api().deleteData<IRecipe>(`recipe?id=${recipeId}`)
    return formatRecipeDate(recipe);
}

export const blankRecipe: IRecipe = {
    recipeId: 0,
    cuisineId: 0,
    staffId: 0,
    user: "",
    recipeName: "",
    calories: 0,
    dateDraft: new Date(0),
    datePublished: new Date(0),
    dateArchived: new Date(0),
    recipeStatus: "",
    recipePic: "",
    isVegan: "",
    numIngredients: 0,
    errorMessage: ""
};