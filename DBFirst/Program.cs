using CodeFirst.DBContext;
using CodeFirst.Infrastructure.Interface;
using CodeFirst.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddScoped(typeof(IPaymentRepository), typeof(PaymentRepository));
builder.Services.AddScoped(typeof(IBasketRepository), typeof(BasketRepository));

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
 