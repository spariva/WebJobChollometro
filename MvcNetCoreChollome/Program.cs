using Microsoft.EntityFrameworkCore;
using MvcNetCoreChollome.Data;
using MvcNetCoreChollome.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = "Data Source=spariva.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=maki;Password=Sacresmont13;Encrypt=True;Trust Server Certificate=True";

//string connectionString =
//    builder.Configuration.GetConnectionString("SqlCasa");

builder.Services.AddTransient<RepositoryChollometro>();

builder.Services.AddDbContext<ChollometroContext>
    (options => options.UseSqlServer(connectionString));



var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Chollometro}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
