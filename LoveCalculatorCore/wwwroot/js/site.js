// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    var mousePos = {};

    function getRandomInt(min, max) {
        return Math.round(Math.random() * (max - min + 1)) + min;
    }

    $(window).mousemove(function (e) {
        mousePos.x = e.pageX;
        mousePos.y = e.pageY;
    });

    $(window).mouseleave(function (e) {
        mousePos.x = -1;
        mousePos.y = -1;
    });

    var draw = setInterval(function () {
        if (mousePos.x > 0 && mousePos.y > 0) {

            var range = 15;

            var color = "background: rgb(" + getRandomInt(0, 255) + "," + getRandomInt(0, 255) + "," + getRandomInt(0, 255) + ");";

            var sizeInt = getRandomInt(10, 30);
            size = "height: " + sizeInt + "px; width: " + sizeInt + "px;";

            var left = "left: " + getRandomInt(mousePos.x - range - sizeInt, mousePos.x + range) + "px;";

            var top = "top: " + getRandomInt(mousePos.y - range - sizeInt, mousePos.y + range) + "px;";

            var style = left + top + color + size;
            $("<div class='ball' style='" + style + "'><h5>♡</h5></div>").appendTo('#wrap').one("webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend", function () { $(this).remove(); });
        }
    },0.5);
});
