using KidegaApp.Infrastructure.Data;
using KidegaApp.Mvc.Data;
using KidegaApp.Mvc.Extensions;
using KidegaApp.Services.Mappings;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(MapProfile));

var connectionStringKidega = builder.Configuration.GetConnectionString("db");

builder.Services.AddInjections(connectionStringKidega);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<KidegaDbContext>();
context.Database.EnsureCreated();
DbSeeding.SeedDatabase(context);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//using (var roleScope = app.Services.CreateScope())
//{
//    var userManager = roleScope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

//    string email = "samet.tunay12@gmail.com";

//    var user = await userManager.FindByEmailAsync(email);
//    await userManager.AddToRoleAsync(user, "Admin");
//}

app.Run();
