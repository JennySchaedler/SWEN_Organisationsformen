using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    // Die [ResponseCache]- und [IgnoreAntiforgeryToken]-Attribute werden auf Klassenebene festgelegt.
    // [ResponseCache] steuert das Caching-Verhalten, und [IgnoreAntiforgeryToken] deaktiviert den Anti-Forgery-Schutz.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        // Eigenschaft zur Speicherung der Anfrage-ID
        public string? RequestId { get; set; }

        // Eigenschaft, die angibt, ob die Anfrage-ID vorhanden ist und angezeigt werden soll
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // Logger-Instanz für die Fehlerprotokollierung
        private readonly ILogger<ErrorModel> _logger;

        // Konstruktor für die ErrorModel-Klasse, der einen Logger entgegennimmt
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        // Methode, die bei einem GET-Request aufgerufen wird
        public void OnGet()
        {
            // Setzt die Anfrage-ID auf die aktuelle Aktivitäts-ID oder den Trace-Identifier der Anforderung
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}