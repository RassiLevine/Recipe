import { useState } from "react"
import "./assets/css/bootstrap.min (4).css";
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import CuisineScreen from "./CuisineScreen"
import RecipeListByCuisine from "./RecipeListByCuisine";
import { IRecipe } from "./DataInterfaces";
import RecipeEdit from "./RecipeEdit";
import { blankRecipe } from "./DataUtil";
import React from "react";

function App() {

  const [selectedCuisineId, setSelectedCuisineId] = useState(0);

  const [selectedRecipeId, setSelectedRecipeId] = useState(0);

  const [isRecipeEdit, setIsRecipeEdit] = useState(false);
  const [recipeForEdit, setRecipeForEdit] = useState(blankRecipe);

  const handleSelectedCuisineId = (cuisineId: number) => {
    setIsRecipeEdit(false);
    setSelectedCuisineId(cuisineId);

  }
  const handleRecipeSelected = (recipeId: number) => {
    setIsRecipeEdit(false);
    setSelectedRecipeId(recipeId);
  };
  const handleRecipeSelectedForEdit = (recipe: IRecipe) => {
    setRecipeForEdit(recipe);;
    setIsRecipeEdit(true);
  };

  return (
    <>
      <div className="container">
        <div className="row p-3 text-center">
          <div className="col-12 col-md-8 col-lg-8">
            <h4>Click on a cuisine to view its recipes.</h4>
            <button onClick={() => handleRecipeSelectedForEdit(blankRecipe)} className="btn btn-primary">New Recipe</button>
          </div>
        </div>
        <div className="row">
          <div className="col-12 md-6 col-lg-8 text-wrap">
            <CuisineScreen onCuisineSelected={handleSelectedCuisineId} />
          </div>
        </div>
        <div className="row">
          <div className="col-12 col-lg-8 text-wrap">
            {isRecipeEdit ? <RecipeEdit key={recipeForEdit.recipeId} recipe={recipeForEdit} /> : <RecipeListByCuisine key={selectedCuisineId} onRecipeSelectedForEdit={handleRecipeSelectedForEdit} onRecipeSelected={handleRecipeSelected} cuisineId={selectedCuisineId} />}
          </div>
        </div>
      </div>
    </>
  )
}

export default App
