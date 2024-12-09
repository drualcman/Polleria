// wwwroot/js/site.js
window.setTheme = (theme) => {
    let linkElement = document.querySelector("link#theme-css");

    if (!linkElement) {
        linkElement = document.createElement("link");
        linkElement.id = "theme-css";
        linkElement.rel = "stylesheet";
        document.head.appendChild(linkElement);
    }

    linkElement.href = `css/theme-${theme}.css`;
};


