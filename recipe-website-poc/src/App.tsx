import { useState } from "react"
import "./assets/css/bootstrap.min (4).css"
import Navbar from "./Navbar"

import CuisineScreen from "./CuisineScreen"
import RecipeListByCuisine from "./RecipeListByCuisine";

function App() {

  const [selectedCuisineId, setSelectedCuisineId] = useState(0);

  const handleSelectedCuisineId = (cuisineId: number) => {
    setSelectedCuisineId(cuisineId);
  }

  return (
    <>
      <div className="container">
        <div className="row">
          <div className="col-12">
            <Navbar />
          </div>
        </div>
        <div className="row p-3 text-center">
          <div className="col-12 col-md-8 col-lg-8">
            <h4>Click on a cuisine to view its recipes.</h4>
          </div>
        </div>
        <div className="row">
          <div className="col-12 md-6 col-lg-8 text-wrap">
            <CuisineScreen onCuisineSelected={handleSelectedCuisineId} />
          </div>
        </div>
        <div className="row">
          <div className="col-12 col-lg-8 text-wrap">
            <RecipeListByCuisine cuisineId={selectedCuisineId} />
          </div>
        </div>
      </div>

    </>
  )
}

export default App
