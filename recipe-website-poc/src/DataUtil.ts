import { ICuisine, IRecipe, IStaff } from "./DataInterfaces";
import { FieldValues } from "react-hook-form";
let baseurl = " https://rlrecipeapi.azurewebsites.net/api/";
baseurl = 'https://localhost:7288/api/'
async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    console.log(url);
    const r = await fetch(url);
    const data = await r.json();

    return data;
}
async function PostData<T>(url: string, form: FieldValues): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url, {
        method: "POST",
        body: JSON.stringify(form),
        headers: { "Content-Type": "application/json" }
    });
    const data = await r.json();
    return data;
};
async function deleteData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url, { method: "DELETE" });
    const data = await r.json();
    return data;
}
export async function fetchCuisine() {
    return await fetchData<ICuisine[]>("Cuisine")
}
export async function fetchRecipeByCuisine(cuisineId: number) {
    console.log(baseurl + "Recipe/bycuisineid/" + cuisineId)
    return await fetchData<IRecipe[]>("Recipe/bycuisineid/" + cuisineId)
}

export async function fetchStaff() {
    return await fetchData<IStaff[]>("Recipe/Staff");
}
export async function PostRecipe(form: FieldValues) {
    return await PostData<IRecipe>("recipe", form);
}

export async function DeleteRecipe(recipeId: number) {
    return await deleteData<IRecipe>(`recipe?id=${recipeId}`)
}

export const blankRecipe: IRecipe = {
    recipeId: 0,
    cuisineId: 0,
    staffId: 0,
    user: "",
    recipeName: "",
    calories: 0,
    dateDraft: "",
    datePublished: "",
    dateArchived: "",
    recipeStatus: "",
    recipePic: "",
    isVegan: "",
    numIngredients: 0,
    errorMessage: ""
};