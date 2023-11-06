// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let elements = document.querySelectorAll('.themebtn');

let clickEvent = (e) => {
    let themeClicked = e.target.getAttribute('data-bs-Theme-Value')
    console.log(themeClicked)
    let html = document.querySelector('html')
    html.setAttribute('data-bs-Theme', themeClicked)
    
}
elements.forEach((item) => {
    item.addEventListener('click', clickEvent)
});