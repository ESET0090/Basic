import react, { use, useEffect, useState} from "react"


export default function useEffectComponent(){

    const suggestions = [
        "maxhub",
        "laptop",
        "bottle",
        "car"
    ];

    const [recommendation, setRecommendation] = useState([])
    useEffect (() => {
        setRecommendation (suggestions.filter((element) => element.includes(search)));
    }, [search]);

    return (
        <div>
            <input value={search} onChange={(e) => setSearch(e.target.value)}/>
            {
                recommendation.map((rec, index) => (<div> key = {index}.{rec}</div>))
            }
        </div>
    )
}

