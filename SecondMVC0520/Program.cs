using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SecondMVC0520.DBModels;
using SecondMVC0520.Repos;
using SecondMVC0520.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//�}�o���Ҩϥ�user secret���o�s�u�r��A�Y�������Ҩϥ�azure app service��user secret�A�h�ݦbazure app service���oconnecion string
builder.Configuration["ConnectionStrings:SecondMvcConnection"] = builder.Configuration["ConnectionStrings:SecondMvcConnection"];





builder.Services.AddDbContext<SecondMVC0520_dbContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SecondMvcConnection"))
);

builder.Services.AddScoped(typeof (IRepository<>), typeof(HomeRepository<>));
builder.Services.AddScoped<HomeServices>();

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
