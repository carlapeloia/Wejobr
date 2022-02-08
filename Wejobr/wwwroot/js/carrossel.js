// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const $responsiveCarousel = document.querySelector(".js-carousel--responsive");

new Glider($responsiveCarousel, {
    slidesToShow: 1,
    slidesToScroll: 1,
    draggable: true,
    duration: 0.25,
    dots: ".js-carousel--responsive-dots",
    arrows: {
        prev: ".js-carousel--responsive-prev",
        next: ".js-carousel--responsive-next",
    },
    responsive: [
        {
            breakpoint: 600,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2,
            },
        },
        {
            breakpoint: 900,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 3,
            },
        },
    ],
});
