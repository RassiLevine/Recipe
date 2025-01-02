
import { ICuisine } from "./DataInterfaces";

interface Props {
    cuisine: ICuisine,
    onSelected: (cuisineId: number) => void;
}

function CuisineCard({ cuisine, onSelected }: Props) {
    return (
        <>

            <div className="card text-align-center " style={{ maxHeight: "auto" }} >
                <img src={`images/${cuisine.cuisineType}Cuisine.jpg`} className="card-img-top" alt="..." style={{ width: "70px", margin: "0 auto", display: "block", borderRadius: "0", maskImage: 'radial-gradient(circle, rgba(0, 0, 0, 1) 50%, rgba(0, 0, 0, 0) 100%)' }} />

                <div className="card-body text-center">

                    <h5 className="card-title">{cuisine.cuisineType}</h5>
                    <p className="card-text">Description of cuisine</p>
                    <button onClick={() => onSelected(cuisine.cuisineId)} className="btn btn-primary">View Recipes</button>


                </div>
            </div>
        </>
    )
}

export default CuisineCard;
