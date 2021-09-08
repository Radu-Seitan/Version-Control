/*let getUsersAndAdresses = async () => {
    const data = await fetch('https://jsonplaceholder.typicode.com/users')
        .then(r => r.json());  
    
    const names = data.map(e => e.name);
    const addresses = data.map(e => e.address);

    const postUsers = (array) => {
        let html = '';
        let count = 0;
        array.forEach(({city, street, suite, zipcode, geo}) => {
            const card = `
            <div class="card">
                <h3>Name: ${names[count]}</h3>
                <p>City: ${city} </p>
                <p>Street: ${street} </p>
                <p>Street: ${suite} </p>
                <p>Street: ${zipcode} </p>
                <p>Geo: ${geo.lat} ${geo.lng} </p>
            </div>
            `;
            html += card;
            count++;
        });
        document.getElementById('firstDiv').innerHTML = html;
    }
    postUsers(addresses);
} */

let getUsersAndAdresses = async () => {
    const users = await fetch('https://jsonplaceholder.typicode.com/users')
        .then(r => r.json());  

    const postUsers = (array) => {
        let html = '';
        array.map((e) => {
            html += `
            <div class="card">
                <h3>Name: ${e.name}</h3>
                <p>City: ${e.address.city} </p>
                <p>Street: ${e.address.street} </p>
                <p>Street: ${e.address.suite} </p>
                <p>Street: ${e.address.zipcode} </p>
                <p>Geo: ${e.address.geo.lat} ${e.address.geo.lng} </p>
            </div>
            `;
        });
        document.getElementById('firstDiv').innerHTML = html;
    }
    postUsers(users);
}

let getTodosAndUsers = async () => {
    const todos = await fetch('https://jsonplaceholder.typicode.com/todos')
        .then(r => r.json());
        const users = await fetch('https://jsonplaceholder.typicode.com/users')
        .then(r => r.json()); 
    
    const postUsers = (array) => {
        let html = '';
        array.forEach((e) => {
            html += `<div class="card2">
            <h3>${e.name}</h3>`;
            const filteredTodos = todos.filter(t => t.userId == e.id).map(t => t.title);
            filteredTodos.map(t => {
                html += `<p>${t}</p>`
            });
            html += `</div>`;
        });
        document.getElementById('secondDiv').innerHTML = html;
    }
    postUsers(users);
} 

document.getElementById('firstButton').addEventListener("click", getUsersAndAdresses);
document.getElementById('secondButton').addEventListener("click", getTodosAndUsers);