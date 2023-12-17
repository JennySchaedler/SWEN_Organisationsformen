// main.js

// Wartet, bis das Dokument vollständig geladen ist, bevor der Code ausgeführt wird.
$(document).ready(function () {
    // Fügt einen Event-Listener für das Mousedown-Ereignis auf allen Elementen mit der Klasse "overlayImage" hinzu.
    $(".overlayImage").on("mousedown", function () {
        // Macht das Element mit der Klasse "overlayImage" ziehbar.
        $(this).draggable({
            containment: 'parent', // Begrenze die Bewegung innerhalb des übergeordneten Elements.
            scroll: false // Deaktiviere das Scrollen, während das Element gezogen wird.
        });
    });
});