let form = document.getElementById("inputForm");

form.addEventListener('submit', function(event) {
    event.preventDefault();

    let searchResult = document.getElementById("search").value;
    var index = 0;
    fetch(`https://api.chucknorris.io/jokes/search?query=${searchResult}`)
        .then((result) => result.json())
        .then((data) => {
            document.getElementById("founded").innerHTML = `
                <p style="text-align: center">Results: ${data.result.length}</p>`

            console.log(data)
            document.getElementById("currentQuote").innerHTML = `
            
            <blockquote  class="blockquote blockquote-custom bg-white p-5 shadow rounded">
                <div class="blockquote-custom-icon bg-info shadow-sm"><i class="fa fa-quote-left text-white"></i></div>
                    <p class="mb-0 mt-2 font-italic">${index+1}. ${data['result'][index]['value']}</p> 
                <footer class="blockquote-footer pt-4 mt-4 border-top">CreatedOn: ${data['result'][index]['created_at']}
                    <br>
                <a href="${data['result'][index]['url']}" class="text-info">@source</a>
                </footer>
            </blockquote>
            
            <button onclick="quote(${++index})" id="next" class="btn btn-danger">Next</button>
            <button onclick="quote(${index-=2})" id="next1" class="btn btn-danger">Prev</button>
            `
        })
});

function quote(index) {
    let searchResult = document.getElementById("search").value;

    fetch(`https://api.chucknorris.io/jokes/search?query=${searchResult}`)
        .then((result) => result.json())
        .then((data) => {
            document.getElementById("currentQuote").innerHTML = `
            <blockquote  class="blockquote blockquote-custom bg-white p-5 shadow rounded">
                <div class="blockquote-custom-icon bg-info shadow-sm"><i class="fa fa-quote-left text-white"></i></div>
                    <p class="mb-0 mt-2 font-italic">${index+1}. ${data['result'][index]['value']}</p>
                    <footer class="blockquote-footer pt-4 mt-4 border-top">CreatedOn: ${data['result'][index]['created_at']}
                    <br>
                <a href="${data['result'][index]['url']}" class="text-info">@source</a>
                </footer>
            </blockquote>

            <button onclick="quote(${++index})" id="next" class="btn btn-danger">Next</button>
            <button onclick="quote(${index-=2})" id="next1" class="btn btn-danger">Prev</button>
            `
        })
}

function randomJoke() {
    fetch(`https://api.chucknorris.io/jokes/random`)
        .then((result) => result.json())
        .then((data) => {

            console.log(data)
            document.getElementById("founded").innerHTML = ``;
            document.getElementById("currentQuote").innerHTML = `
            <blockquote class="blockquote blockquote-custom bg-white p-5 shadow rounded">
                <div class="blockquote-custom-icon bg-info shadow-sm"><i class="fa fa-quote-left text-white"></i></div>
                    <p class="mb-0 mt-2 font-italic">${data.value}</p>
                    <footer class="blockquote-footer pt-4 mt-4 border-top">CreatedOn: ${data.created_at}
                    <br>
                <a href="${data.url}" class="text-info">@source</a>
                </footer>
            </blockquote>`
        })
}