using MeuSiteEmMVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Connection>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36))
    ));

builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:5001");
=======
>>>>>>> 3df0da39a5325290ed31a0ea8e582449fed8c637

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();