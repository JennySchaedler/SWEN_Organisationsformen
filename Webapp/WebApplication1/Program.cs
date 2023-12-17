var builder = WebApplication.CreateBuilder(args);

// Services dem Container hinzufügen.
builder.Services.AddRazorPages();

var app = builder.Build();

// Die HTTP-Anforderungspipeline konfigurieren.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Der Standardwert für HSTS beträgt 30 Tage. Dies kann für Produktionsumgebungen geändert werden, siehe https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();