import Film from "../Film/Film";
import { useState } from "react";

const Button = ({props}) => {
    const [showMore, setShowMore] = useState(false)

    const filmsArray = showMore && props && props.map(film => (
        <Film props = {film} key={`film-${props.indexOf(film)}`}/>
    ));

    return (
        <>
            <button className="button" onClick={() => setShowMore(!showMore)}>
                Show more
            </button>
            {filmsArray}
        </>
    )
}

export default Button;