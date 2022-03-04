using CodeFirst.DBContext;
using CodeFirst.Repositories.Interface;
using CodeFirst.Repositories.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

builder.Services.AddDbContext<Context>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("SellerConnectionString")));

//
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
 