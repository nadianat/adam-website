using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using testhotel.Web.Data;
using testhotel.Web.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<testhotelWebContext>(options =>
//using testhotel.Web.Data;
    options.UseSqlServer(builder.Configuration.GetConnectionString("testhotelWebContext") ?? throw new InvalidOperationException("Connection string 'testhotelWebContext' not found.")));

builder.Services.AddDbContext<testhotelWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("testhotelWebContext") ?? throw new InvalidOperationException("Connection string 'testhotelWebContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
