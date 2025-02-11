function loadAnimaciones() {
    const elementos = document.querySelectorAll(".move-right, .move-left, .move-up, .move-down, .move-zoom");
    const observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                entry.target.classList.add("active");
            }
        });
    });

    elementos.forEach(function (elemento) {
        observer.observe(elemento);
    });

    const hijos = document.querySelectorAll(".h-parallax");

    window.addEventListener("scroll", function () {
        const scrollTop = window.scrollY;
        hijos.forEach(function (hijo) {
            const speed = parseFloat(hijo.getAttribute("data-speed"));
            hijo.style.transform = `translateY(${scrollTop * speed}px)`;
        });
    });

    console.log("Animaciones del home ejecutadas correctamente");
}