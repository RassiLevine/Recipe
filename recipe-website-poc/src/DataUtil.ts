import { ICuisine, IRecipe } from "./DataInterfaces";

const baseurl = " https://rlrecipeapi.azurewebsites.net/api/";
async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    console.log(url);
    const r = await fetch(url);
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