using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    // IndexModel ist eine Razor Page Model-Klasse für die Indexseite.
    public class IndexModel : PageModel
    {
        // Logger-Instanz für die Protokollierung von IndexModel-bezogenen Vorgängen.
        private readonly ILogger<IndexModel> _logger;

        // Konstruktor für IndexModel, der einen Logger entgegennimmt.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // OnGet ist eine Methode, die aufgerufen wird, wenn eine HTTP-GET-Anforderung für die Indexseite erfolgt.
        public void OnGet()
        {
            // Hier können Logik und Datenmanipulation für die Verarbeitung einer GET-Anforderung hinzugefügt werden.
            // Derzeit ist die Methode leer, es können jedoch weitere Aktionen hinzugefügt werden.
        }
    }
}