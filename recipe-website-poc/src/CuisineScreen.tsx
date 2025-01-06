import { useEffect, useState } from "react";
import { ICuisine } from "./DataInterfaces";
import { fetchCuisine } from "./DataUtil";
import CuisineCard from "./CuisineCard";
import React from "react";
interface Props { onCuisineSelected: (cuisineId: number) => void }



function CuisineScreen({ onCuisineSelected }: Props) {
    const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisine, setSelectedCuisine] = useState(0);
    useEffect(() => {
        const fetchData = async () => {
            const data = await fetchCuisine();
            setCuisineList(data);
            console.log('cusisinelist', data);
            if (data.length > 0 && selectedCuisine == 0) {
                handleSelectedCuisine(data[1].cuisineId);
            }
        }
        fetchData();
    }
        , [selectedCuisine]);

    function handleSelectedCuisine(cuisineId: number) {
        setSelectedCuisine(cuisineId);
        onCuisineSelected(cuisineId);
        console.log('cuisineid in cuisine screen', cuisineId);
    }
    return (
        <>
            <div className="row">
                {cuisineList.map(c =>
                    c.cuisineId > 0 && (
                        <div key={c.cuisineId} className="col-4">
                            <CuisineCard cuisine={c} onSelected={handleSelectedCuisine} />
                        </div>
                    )
                )}

            </div>
        </>
    )
}
//FrenchCuisine.jpg
//FrenchCuisine.png
export default CuisineScreen