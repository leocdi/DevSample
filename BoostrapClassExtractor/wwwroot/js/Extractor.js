(function () {

    let classes = [];
    Array.prototype.forEach.call(document.styleSheets[0].cssRules, function (a) { classes.push(a.selectorText) })

    fetch("Home/PostStyles", {
        method: "POST",
        body: JSON.stringify(
            classes
        ),
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    });
})();