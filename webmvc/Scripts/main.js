$(function () {
    $(".asyncPartial").each(function (i, item) {
        var url = $(item).data("url");
        if (url && url.length > 0) {
            $(item).load(url);
        }
    });

    //// toastr ======================================================//
    //toastr.options = {
    //    "closeButton": true,
    //    "debug": false,
    //    "newestOnTop": false,
    //    "progressBar": false,
    //    "positionClass": "toast-bottom-left",
    //    "preventDuplicates": false,
    //    "onclick": null,
    //    "showDuration": "300",
    //    "hideDuration": "1000",
    //    "timeOut": "5000",
    //    "extendedTimeOut": "1000",
    //    "showEasing": "swing",
    //    "hideEasing": "linear",
    //    "showMethod": "fadeIn",
    //    "hideMethod": "fadeOut"
    //}
    //// end toastr ==================================================//

    $(".testimonial-carousel").slick({
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        arrows: false,
        dots: true,
        prevArrow: $(".testimonial-carousel-controls .prev"),
        nextArrow: $(".testimonial-carousel-controls .next")
    });
});
