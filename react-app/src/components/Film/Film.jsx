import axios from "axios";
import { useState, useEffect, useCallback } from "react";

const Film = ({ props }) => {
    const [movie, setMovie] = useState()

    useEffect(() => {
        fetchMovie();
    }, [])

    const fetchMovie = async () => {
        const res = await axios.get(props);
        const movie = res.data.title;
        setMovie(movie);
    }

    return (
        <p>
            {movie}
        </p>
    )
}
export default Film;