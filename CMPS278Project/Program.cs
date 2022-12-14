var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services); // calling ConfigureServices method
var app = builder.Build();
startup.Configure(app, builder.Environment); // calling Configure method

// using Menu.Data;
// using MenuItemsRepo.Interfaces;
// using MenuItems.Repos;
// using CakePopsRepo.Interfaces;
// using CakePops.Repos;
// using BrowniesRepo.Interfaces;
// using Brownies.Repos;
// using CinnamonRollsRepo.Interfaces;
// using CinnamonRolls.Repos;
// using CookiesRepo.Interfaces;
// using Cookies.Repos;
// using CupcakesRepo.Interfaces;
// using Cupcakes.Repos;
// using CartItemsRepo.Interfaces;
// using CartItems.Repos;
// using Users.Models;
// using JwtServices.Services;
// using Microsoft.AspNetCore.Cors;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.IdentityModel.Tokens;
// using System.Text;


// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddCors(options =>
// {
//     options.AddDefaultPolicy(
//                       builder  =>
//                       {
//                           builder.WithOrigins(
//                                               "https://localhost:5000",
//                                               "http://localhost:5000")
//                                                 .AllowAnyHeader()
//                                                 .AllowAnyMethod()
//                                                 .AllowCredentials();
//                       });
// });

// // Add services to the container.

// builder.Services.AddControllersWithViews();
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<AppDbContext>(
//     opt =>
//     {
//         opt.UseSqlite(builder.Configuration.GetConnectionString("sqlite"));
//     }
// );

// builder.Services.AddIdentityCore<User>(options => {
//         options.SignIn.RequireConfirmedAccount = false;
//         options.User.RequireUniqueEmail = true;
//         options.Password.RequireDigit = false;
//         options.Password.RequiredLength = 6;
//         options.Password.RequireNonAlphanumeric = false;
//         options.Password.RequireUppercase = false;
//         options.Password.RequireLowercase = false;
//     })
//     .AddEntityFrameworkStores<AppDbContext>();

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters()
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = true,
//             ValidateIssuerSigningKey = true,
//             ValidAudience = "Jwt:Audience",
//             ValidIssuer = "Jwt:Issuer",
//             IssuerSigningKey = new SymmetricSecurityKey(
//                 Encoding.UTF8.GetBytes("Jwt:Key")
//             )
//         };
//     });

// builder.Services.AddScoped<IMenuItemRepo, MenuItemRepo>();
// builder.Services.AddScoped<ICakePopRepo, CakePopRepo>();
// builder.Services.AddScoped<IBrownieRepo, BrownieRepo>();
// builder.Services.AddScoped<ICinnamonRollRepo, CinnamonRollRepo>();
// builder.Services.AddScoped<ICookieRepo, CookieRepo>();
// builder.Services.AddScoped<ICupcakeRepo, CupcakeRepo>();
// builder.Services.AddScoped<ICartItemRepo, CartItemRepo>();
// builder.Services.AddScoped<JwtService>();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();
// app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();
// // app.UseSession();
// app.UseCors();


// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action=Index}/{id?}");

// app.MapFallbackToFile("index.html");;

// app.Run();
