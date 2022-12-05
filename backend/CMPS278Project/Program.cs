// var builder = WebApplication.CreateBuilder(args);
// var startup = new Startup(builder.Configuration);
// startup.ConfigureServices(builder.Services); // calling ConfigureServices method
// var app = builder.Build();
// startup.Configure(app, builder.Environment); // calling Configure method

using Microsoft.EntityFrameworkCore;
using Menu.Data;
using MenuItemsRepo.Interfaces;
using MenuItems.Repos;
using CakePopsRepo.Interfaces;
using CakePops.Repos;
using BrowniesRepo.Interfaces;
using Brownies.Repos;
using CinnamonRollsRepo.Interfaces;
using CinnamonRolls.Repos;
using CookiesRepo.Interfaces;
using Cookies.Repos;
using CupcakesRepo.Interfaces;
using Cupcakes.Repos;
using Microsoft.AspNetCore.Cors;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                      builder  =>
                      {
                          builder.WithOrigins("https://localhost:44451",
                                              "http://localhost:5119",
                                              "https://localhost:7277")
                                                .AllowAnyHeader()
                                                .AllowAnyMethod()
                                                .AllowCredentials();
                      });
});

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(
    opt =>
    {
        opt.UseSqlite(builder.Configuration.GetConnectionString("sqlite"));
    }
);

builder.Services.AddScoped<IMenuItemRepo, MenuItemRepo>();
builder.Services.AddScoped<ICakePopRepo, CakePopRepo>();
builder.Services.AddScoped<IBrownieRepo, BrownieRepo>();
builder.Services.AddScoped<ICinnamonRollRepo, CinnamonRollRepo>();
builder.Services.AddScoped<ICookieRepo, CookieRepo>();
builder.Services.AddScoped<ICupcakeRepo, CupcakeRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

app.Run();
