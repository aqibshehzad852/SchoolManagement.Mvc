// In Program.cs
using SchoolManagement.Mvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using Microsoft.CodeAnalysis.Options;
using Auth0.AspNetCore.Authentication;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conn= builder.Configuration.GetConnectionString("SchoolManangementDbConnection");
builder.Services.AddDbContext<SchoolManagementDbContext>(w => w.UseSqlServer(conn));

builder.Services.AddAuth0WebAppAuthentication(Options => {
    Options.Domain = builder.Configuration["Auth0:Domain"];
    Options.ClientId = builder.Configuration["Auth0:ClientId"];

});
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
