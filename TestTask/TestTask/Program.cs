using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositorys;
using Storage;
using App;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TestTaskContext>(options =>
{
    // Configure the context to use sqlite.
    options.UseSqlite($"Data Source=testtask.db", b => b.MigrationsAssembly("TestTask"));


});
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISubdivisionsRepository, SubdivisionsRepository>();
builder.Services.AddScoped<ISubdivisionsService, SubdivisionsService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseMvc();

app.Run();
