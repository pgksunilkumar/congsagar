$(document).ready(function (e) {
    $('.search-panel .dropdown-menu').find('a').click(function (e) {
        e.preventDefault();
        var param = $(this).attr("href").replace("#", "");
        var concept = $(this).text();
        $('.search-panel span#search_concept').text(concept);
        $('.input-group #search_param').val(param);
    });
    $(".element").typed({
        strings: ["Buy", "Sell", "Rent"],
        //optional
        typeSpeed: 100, //default
        //optional
        backSpeed: 30, //default
        //optional
        startDelay: 500, //default
        //optional
        backDelay: 500, //default
        //optional
        loop: true, //default
        //optional    
        showCursor: false, //default
        //optional    
        //cursorChar: "|", //default
    });
});