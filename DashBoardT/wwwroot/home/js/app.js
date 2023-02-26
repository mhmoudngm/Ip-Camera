$(document).ready(function () {
  $("#hero-slider").owlCarousel({
    loop: true,
    margin: 0,
    nav: true,
    items: 1,
    dots: false,
    smartspeed: 1000,
    navText: ["PREV", "NEXT"],
    responsive: {
      0: { nav: false },
      768: { nav: true },
    },
  });

  $("#project-slider").owlCarousel({
    loop: true,
    margin: 0,
    nav: true,
    dots: false,
    smartspeed: 1000,
    margin: 24,
    navText: ["PREV", "NEXT"],
    responsive: {
      0: { items: 1, nav: false, margin: 0 },
      768: { items: 2 },
      1140: { items: 2, center: true },
    },
  });

  $("#reviews-slider").owlCarousel({
    loop: true,
    margin: 10,
    nav: false,
    dots: true,
    smartspeed: 800,
    responsive: {
      0: {},
      768: {},
      1140: { dots: true, items: 1 },
    },
  });
});
