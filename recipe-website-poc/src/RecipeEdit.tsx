import { FieldValues, useForm } from "react-hook-form"
import { ICuisine, IRecipe, IStaff } from "./DataInterfaces"
import { useState, useEffect } from "react";
import { blankRecipe, DeleteRecipe, fetchCuisine, fetchStaff, PostRecipe } from "./DataUtil";
import React from "react";
import { getUserStore } from "@rassilevine/reactutils";
import { ToastContainer, toast } from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';


interface Props {
    recipe: IRecipe;
}
function RecipeEdit({ recipe }: Props) {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const { register, handleSubmit, reset } = useForm({ defaultValues: recipe })
    const [staff, setStaff] = useState<IStaff[]>([]);
    const [cuisine, setCuisine] = useState<ICuisine[]>([]);
    const [errorMsg, setErrorMsg] = useState("");
    const roleRank = useUserStore(state => state.roleRank);

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
    useEffect(() => {
        reset(recipe);
    }, [recipe, reset]);

    const submitForm = async (data: FieldValues) => {
        const transformedData = {
            ...data,
            datePublished: data.datePublished === "" ? null : data.datePublished,
            dateArchived: data.dateArchived === "" ? null : data.dateArchived
        };
        try {
            setErrorMsg("");
            const r = await PostRecipe(transformedData);
            setErrorMsg(r.errorMessage)
            if (!r.errorMessage) {
                toast.success('Recipe Saved!');
                reset(r);
            }
        }
        catch (error: unknown) {
            if (error instanceof Error) {
                setErrorMsg(error.message);
            } else {
                setErrorMsg("An error occurred");
            }
        }
    };

    const handleDelete = async () => {
        try {
            const r = await DeleteRecipe(recipe.recipeId);
            setErrorMsg(r.errorMessage);
            console.log(r.errorMessage);
            if (r.errorMessage == "") {
                reset(blankRecipe);
                toast.success("Recipe Deleted!")
            }
        }
        catch (error: unknown) {
            if (error instanceof Error) {
                setErrorMsg(error.message);
            }
            else {
                setErrorMsg("error happened");
            }
        }


    };

    return (
        <>
            <div className="bg-light mt-4 p-4">
                <ToastContainer />
                <div className="row">
                    <div className="col-12">
                        <h2 className="text-danger" id="msg">{errorMsg ? errorMsg : null}</h2>
                    </div>
                </div>
                <div className="row">
                    <div className="col-6">
                        <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                            <div className="mb-3">
                                <label htmlFor="recipeId" className="form-label" hidden>Recipe ID:</label>
                                <input type="number"  {...register("recipeId")} className="form-control" hidden />
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
                                <input type="date" {...register("dateDraft")} className="form-control" required />
                                {/* defaultValue={recipe.dateDraft ? new Date(recipe.datePublished).toISOString().split('T')[0] : undefined} */}
                            </div>
                            <div className="mb-3">
                                <label htmlFor="dataPublished" className="form-label">Date Published:</label>
                                <input type="date" {...register("datePublished")} className="form-control" />
                                {/* defaultValue={recipe.datePublished ? new Date(recipe.datePublished).toISOString().split('T')[0] : undefined} */}
                            </div>
                            <div className="mb-3">
                                <label htmlFor="dataArchived" className="form-label">Date Archived:</label>
                                <input type="date" {...register("dateArchived")} className="form-control" />
                                {/* defaultValue={recipe.dateArchived ? new Date(recipe.datePublished).toISOString().split('T')[0] : undefined} */}
                            </div>
                            <div className="mb-3">
                                <label htmlFor="recipeStatus" className="form-label">Recipe Status:</label>
                                <input type="text" {...register("recipeStatus")} className="form-control" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="isVegan" className="form-label">Is Vegan?:</label>
                                <input type="text" {...register("isVegan")} className="form-control" />
                            </div>
                            <div className="mb-3">
                                <label htmlFor="cuisineId" className="form-label">Cuisine:</label>
                                <select {...register("cuisineId")} className="form-select">
                                    {cuisine.map(c => <option key={c.cuisineId} value={c.cuisineId}>{c.cuisineType}</option>)}
                                </select>
                            </div>
                            <div className="mb-3">
                                <label htmlFor="staffId" className="form-label">Staff:</label>
                                <select {...register("staffId")} className="form-select">
                                    {staff.map(s => <option key={s.staffId} value={s.staffId}>{s.staffLastName}</option>)}
                                </select>
                            </div>
                            <div className="mb-3">
                                <label htmlFor="recipePic" className="form-label">Recipe Pic:</label>
                                <input type="text" {...register("recipePic")} className="form-control" />
                            </div>
                            <button type="submit" className="btn btn-primary">Submit</button>
                            {roleRank >= 3 ?
                                < button onClick={handleDelete} type="button" id="btndelete" className="btn btn-danger">Delete</button>
                                : null}
                        </form>
                    </div>
                </div>
            </div>
        </>
    )
};

export default RecipeEdit