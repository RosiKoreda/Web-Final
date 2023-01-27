//----------------------------------------Slider JS----------------------------------------------//
$('.owl-carousel').owlCarousel({
    loop: true,
    center: true,
    margin: 10,
    nav: true,
    autoplay: true,
    autoplayTimeout: 5000,  
    autoplayHoverPause: true,
    responsive: {
        0: {
            items: 1
        }
    }
})
var owl = $('.owl-carousel');
owl.owlCarousel({
    items: 4,
    loop: true,
    margin: 10,
    autoplay: true,
    autoplayTimeout: 1000,
    autoplayHoverPause: true
});
//----------------------------------------Slider JS--------END--------------------------------------//



