import { useEffect, useState } from "react"
import { IRecipe } from "./DataInterfaces"
import { fetchRecipeByCuisine } from "./DataUtil"

interface Props {
    cuisineId: number,
    onRecipeSelected: (recipeId: number) => void;
    onRecipeSelectedForEdit: (recipe: IRecipe) => void
};

function RecipeListByCuisine({ cuisineId, onRecipeSelected, onRecipeSelectedForEdit }: Props) {
    console.log('onrec selected for edit in recipelist comp', onRecipeSelectedForEdit);
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);
    const [selectedRecipeId, setSelectedRecipeId] = useState(0);
    useEffect(() => {
        if (cuisineId > 0) { }
        const fetchRecipeByCuisineId = async () => {
            if (cuisineId > 0) {
                const data = await fetchRecipeByCuisine(cuisineId);
                setRecipeList(data);
                if (data.length > 0) {
                    handleSelecteRecipe(data[0].recipeId)
                }
            }
        };
        fetchRecipeByCuisineId();
    }, [cuisineId]);

    function handleSelecteRecipe(recipeId: number) {
        setSelectedRecipeId(recipeId);
        onRecipeSelected(recipeId);
    }
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
                        <th scope="col">Edit Recipe</th>
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
                            <td scope="row" style={{ verticalAlign: 'middle' }}><button onClick={() => onRecipeSelectedForEdit(r)} className="btn btn-secondary">Edit</button></td>
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