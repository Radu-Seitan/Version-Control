import Button from "../Button/Button";
import HeartWithClick from "../HeartWithClick/HeartWithClick";


const Card = ({ props }) => {
    return (
        <div className="card">
            <div className="card-header">
                <h3 className="card-header-name">
                    Name : {props.name}
                </h3>
                <HeartWithClick />
            </div>
            <div className="card-body">
                <p>Height : {props.height}</p>
                <p>Mass : {props.mass}</p>
                <p>Hair color : {props.hair_color}</p>
                <p>Skin color : {props.skin_color}</p>
                <p>Eye color : {props.eye_color}</p>
                <p>Gender : {props.gender}</p>
                <p>Birth year : {props.birth_year}</p>
            </div>
            <div className="card-footer">
                <Button props={props.films} />
            </div>
        </div>
    )
}

export default Card;