import React, { useEffect, useState } from 'react'
//import fetchPeople from './people';
import Card from '../Card/Card';
import axios from 'axios';
import Button from '../Button/Button';

const People = () => {
    const [people, setPeople] = useState(null);

    useEffect(() => {
        fetchPeople();
    }, []);

    const fetchPeople = async () => {
        const res = await axios.get('https://swapi.dev/api/people');
        const people = res.data.results;
        setPeople(people);
    };

    const cardsArray = people && people.map(person => (
        <Card props={person} key={`card-${people.indexOf(person)}`} />
    ));

    return (
        <div className="cards">
            {cardsArray}
        </div>

    );
}

export default People;