import { useEffect, useState } from "react"
import { IRecipe } from "./DataInterfaces"
import { fetchRecipeByCuisine } from "./DataUtil"

interface Props {
    cuisineId: number
}
function RecipeListByCuisine({ cuisineId }: Props) {
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);

    useEffect(() => {
        if (cuisineId > 0) { }
        const fetchRecipeByCuisineId = async () => {
            if (cuisineId > 0) {


                const data = await fetchRecipeByCuisine(cuisineId);
                setRecipeList(data);
            }
        };
        fetchRecipeByCuisineId();
    }, [cuisineId]);
    return (
        <>
            <table className="table">
                <thead>
                    <tr>
                        <th scope="col" />
                        <th scope="col">Recipe Name</th>
                        <th scope="col">User</th>
                        <th scope="col">Calories</th>
                        <th scope="col">Status</th>
                        <th scope="col">Vegan</th>
                        <th scope="col">Ingredients</th>
                    </tr>
                </thead>
                <tbody>{
                    recipeList.map(r =>
                        <tr key={r.recipeId}>
                            <td scope="row" style={{ verticalAlign: 'middle' }} ><img src={`images/${r.recipeName.replace(/ /g, '_')}.jpg`} alt="reicpe image" style={{ height: "100px", maskImage: 'radial-gradient(circle, rgba(0, 0, 0, 1) 50%, rgba(0, 0, 0, 0) 100%)', }} /></td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.recipeName}</td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.user}</td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.calories}</td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.recipeStatus}</td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.isVegan}</td>
                            <td scope="row" style={{ verticalAlign: 'middle' }} >{r.numIngredients}</td>
                            {/* <td><button onClick={() => onDeleteRecipe(r.recipeId)} className="btn btn-danger">X</button></td> */}
                        </tr>)
                }
                </tbody>
            </table>
        </>
    )
}
//
export default RecipeListByCuisine