document.querySelector("head > link:nth-child(4)").outerHTML = '<link rel="stylesheet" href="assets/core/loading.css">';
function changeStyle() {
    document.getElementById("heady").style.background = "white";
    document.getElementById("navy").style.display = "none";
    document.getElementById("full").style.display = "none";
    document.getElementById("bod").style.color = "white";
    document.querySelector("head > link:nth-child(4)").outerHTML = '<link rel="stylesheet" href="assets/core/styling.css">';
    setTimeout(delLoadElem, 250);
}
function delLoadElem() {
    var loadelem = document.querySelector("head > link:nth-child(5)");
    loadelem.parentNode.removeChild(loadelem);
    setTimeout(styleShit, 150);
}
function styleShit() {
    document.getElementById("heady").style.background = "var(--background)";
    document.getElementById("navy").style.display = "inherit";
    document.getElementById("load").style.display = "none";
    document.getElementById("full").style.display = "grid";
    document.getElementById("bod").style.color = "black";
}
function unchecknav() {
    document.getElementById("nav-toggle").checked = false;
}
