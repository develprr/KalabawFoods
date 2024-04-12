using Microsoft.EntityFrameworkCore;
using KalabawFoods.FrontEnd.Components;
using KalabawFoods.FrontEnd.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<KalabawFoodsDbContext>(opt => opt.UseNpgsql(
    builder.Configuration.GetConnectionString("KalabawFoodsDb")));
var app = builder.Build();


// await EnsureDatabaseIsMigrated(app.Services);
/* async Task EnsureDatabaseIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var ctx = scope.ServiceProvider.GetService<KalabawFoodsDbContext>();
    if (ctx is not null)
    {
        await ctx.Database.MigrateAsync();
    }

}*/


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
