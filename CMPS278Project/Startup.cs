using Menu.Data;
using MenuItemsRepo.Interfaces;
using CartItemsRepo.Interfaces;
using CartItems.Repos;
using Users.Models;
using JwtServices.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MenuItems.Repos;

public class Startup {
    public IConfiguration configRoot {
        get;
    }
    public Startup(IConfiguration configuration) {
        configRoot = configuration;
    }
    public void ConfigureServices(IServiceCollection services) {
        services.AddRazorPages();
        services.AddCors(options =>
            {
                // options.AddDefaultPolicy(
                //     builder  =>
                //     {
                //         builder.WithOrigins("https://localhost:5001",
                //                             "http://localhost:5000")
                //                                 .AllowAnyHeader()
                //                                 .AllowAnyMethod()
                //                                 .AllowCredentials();
                //     }
                // );
                options.AddPolicy("CorsPolicy", builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

        services.AddControllersWithViews();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<AppDbContext>(
            opt =>
            {
                opt.UseSqlite(configRoot.GetConnectionString("sqlite"));
            }
        );

        services.AddIdentity<User, IdentityRole>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
            .AddEntityFrameworkStores<AppDbContext>();

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidAudience = configRoot["Jwt:Audience"],
                    ValidIssuer = configRoot["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configRoot["Jwt:Key"])
                    )
                };
            });

        services.AddScoped(typeof(IMenuItemRepo<>), typeof(MenuItemRepo<>));
        services.AddScoped<ICartItemRepo, CartItemRepo>();
        services.AddScoped<JwtService>();
    }
    public void Configure(WebApplication app, IWebHostEnvironment env) {
        if (!app.Environment.IsDevelopment()) {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors("CorsPolicy");
        app.UseAuthentication();
        app.UseAuthorization();

        // app.UseEndpoints(endpoints =>
        //     {
        //         endpoints.MapControllers();
        //     });
            
        // app.MapRazorPages();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html");
        app.Run();
    }
}