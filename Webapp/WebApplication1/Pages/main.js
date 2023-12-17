// Lokales JavaScript

// Diese Funktion wird aufgerufen, wenn das Dokument vollständig geladen ist.
$(document).ready(function () {
    // Selektiert alle Elemente mit der Klasse "overlayImage" und fügt einen Event-Listener für den Maus-Druck hinzu.
    $(".overlayImage").on("mousedown", function () {
        // Macht das ausgewählte Element (Bild mit Klasse "overlayImage") verschiebbar (drag-and-drop).
        $(this).draggable({
            // Begrenzt die Verschiebung innerhalb des übergeordneten Elements (parent container).
            containment: 'parent',
            // Deaktiviert das automatische Scrollen während des Ziehens.
            scroll: false
        });
    });
});