

$(document).ready(function () {
    var active;
    $('.toogle').each((index, item) => {
        active = $(item);
        //$(item).click((e) => {
        //    e.preventDefault;
        //    $(".toogle").removeClass("active");
        //    $(item).addClass("active");
        //})
    })
    localStorage.setItem('active', active);
    $('.toogle').each((index, item) => {
        if (item == localStorage.getItem('active')) {
            item.addClass("active");
        }

    })


})