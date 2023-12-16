// Lokales JavaScript
$(document).ready(function () {
    $(".overlayImage").on("mousedown", function () {
        $(this).draggable({
            containment: 'parent',
            scroll: false
        });
    });
});
