import { FieldValues, useForm } from "react-hook-form"
import { ICuisine, IRecipe, IStaff } from "./DataInterfaces"
import { useState, useEffect } from "react";
import { blankRecipe, DeleteRecipe, fetchCuisine, fetchStaff, PostRecipe } from "./DataUtil";

interface Props {
    recipe: IRecipe;
}
function RecipeEdit({ recipe }: Props) {

    const { register, handleSubmit, reset } = useForm({ defaultValues: recipe })
    const [staff, setStaff] = useState<IStaff[]>([]);
    const [cuisine, setCuisine] = useState<ICuisine[]>([]);
    const [errorMsg, setErrorMsg] = useState("");

    useEffect(() => {
        const fetchData = async () => {
            const data = await fetchStaff();
            setStaff(data);
            reset(recipe);
        }
        fetchData();
    }
        , []);
    useEffect(() => {
        const fetchData = async () => {
            const data = await fetchCuisine();
            setCuisine(data);
            reset(recipe);
        }
        fetchData();
    }
        , []);
    const submitForm = async (data: FieldValues) => {
        const r = await PostRecipe(data);
        setErrorMsg(r.errorMessage)
        reset(r);
        console.log("data", data, 'errormsg', errorMsg);
    };
    const handleDelete = async () => {
        const r = await DeleteRecipe(recipe.recipeId);
        setErrorMsg(r.errorMessage);
        if (r.errorMessage == "") {
            reset(blankRecipe);
        }

    };

    return (
        <>
            <div className="bg-light mt-4 p-4">
                <div className="row">
                    <div className="col-12">
                        <h2 id="hmsg">{errorMsg}</h2>
                    </div>
                </div>
                <div className="row">
                    <div className="col-6">
                        <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                            <div className="mb-3">
                                <label htmlFor="recipeId" className="form-label">Recipe ID:</label>
                                <input type="number"  {...register("recipeId")} className="form-control" required />
                            </div>

                            <div className="mb-3">
                                <label htmlFor="recipeName" className="form-label">Recipe Name:</label>
                                <input type="text" {...register("recipeName")} className="form-control" required />
                            </div>

                            <div className="mb-3">
                                <label htmlFor="calories" className="form-label">calories:</label>
                                <input type="number" {...register("calories")} className="form-control" required />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="dataDraft" className="form-label">Date Draft:</label>
                                <input type="date" {...register("dateDraft")} className="form-control" required defaultValue={new Date().toISOString().split('T')[0]} />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="dataPublished" className="form-label">Date Published:</label>
                                <input type="date" {...register("datePublished")} className="form-control" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="dataArchived" className="form-label">Date Archived:</label>
                                <input type="date" {...register("dateArchived")} className="form-control" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="recipeStatus" className="form-label">Recipe Status:</label>
                                <input type="text" {...register("recipeStatus")} className="form-control" required />
                            </div>
                            {/* <div className="mb-3">
                                <label htmlFor="recipePic" className="form-label">recipe:</label>
                                <input type="text" {...register("recipePic")} className="form-control" required />
                            </div> */}
                            <div className="mb-3">
                                <label htmlFor="isVegan" className="form-label">Is Vegan?:</label>
                                <input type="text" {...register("isVegan")} className="form-control" required />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="cuisineId" className="form-label">CuisineId:</label>
                                <select {...register("cuisineId")} className="form-select">
                                    {cuisine.map(c => <option key={c.cuisineId} value={c.cuisineId}>{c.cuisineType}</option>)}
                                </select>
                            </div>
                            <div className="mb-3">
                                <label htmlFor="staffId" className="form-label">Staff Id:</label>
                                <select {...register("staffId")} className="form-select">
                                    {staff.map(s => <option key={s.staffId} value={s.staffId}>{s.staffLastName}</option>)}
                                </select>
                            </div>
                            <div className="mb-3">
                                <label htmlFor="recipePic" className="form-label">Recipe Pic:</label>
                                <input type="text" {...register("recipePic")} className="form-control" />
                            </div>
                            {/* <div className="mb-3">
                                <label htmlFor="numIngredients" className="form-label">Num Ing:</label>
                                <input type="number" {...register("numIngredients")} className="form-control" />
                            </div> */}
                            <button type="submit" className="btn btn-primary">Submit</button>
                            <button onClick={handleDelete} type="button" id="btndelete" className="btn btn-danger">Delete</button>
                        </form>
                    </div>
                </div>
            </div>
        </>
    )
};

export default RecipeEdit