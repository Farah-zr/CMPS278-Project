// using Microsoft.EntityFrameworkCore;
// using Menu.Data;
// using MenuItemsRepo.Interfaces;
// using MenuItems.Repos;
// using Microsoft.AspNetCore.Cors;

// public class Startup {
//     public IConfiguration configRoot {
//         get;
//     }
//     public Startup(IConfiguration configuration) {
//         configRoot = configuration;
//     }
//     public void ConfigureServices(IServiceCollection services) {
//         services.AddRazorPages();
//         services.AddCors(options =>
//             {
//                 options.AddDefaultPolicy(
//                                 builder  =>
//                                 {
//                                     builder.WithOrigins("https://localhost:44451",
//                                                         "https://localhost:5000",
//                                                         "https://localhost:5001")
//                                                             .AllowAnyHeader()
//                                                             .AllowAnyMethod();
//                                 });
//             });

//         services.AddControllersWithViews();
//         services.AddControllers();
//         services.AddEndpointsApiExplorer();
//         services.AddSwaggerGen();
//         services.AddDbContext<AppDbContext>(
//             opt =>
//             {
//                 opt.UseSqlite(configRoot.GetConnectionString("sqlite"));
//             }
//         );

//         services.AddScoped<IMenuItemRepo, MenuItemRepo>();
//     }
//     public void Configure(WebApplication app, IWebHostEnvironment env) {
//         if (!app.Environment.IsDevelopment()) {
//             app.UseExceptionHandler("/Error");
//             // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//             app.UseHsts();
//         }
//         app.UseHttpsRedirection();
//         app.UseStaticFiles();
//         app.UseRouting();
//         app.UseCors();
//         app.UseAuthorization();
//         app.MapRazorPages();
//         app.Run();
//     }
// }