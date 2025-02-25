global using examSystem.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add DbContext Configuration
/*builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));*/

builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
        {
          var connetionString = builder.Configuration.GetConnectionString("DefaultConnection");
          options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
