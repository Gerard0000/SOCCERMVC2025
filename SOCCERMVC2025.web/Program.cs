using Microsoft.EntityFrameworkCore;
using SOCCERMVC2025.web.Data;
using SOCCERMVC2025.web.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//inyectamos la base de datos
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=SoccerConnection"));
//inyectamos el seeder
builder.Services.AddTransient<SeedDb>();
//inyectamos el imageHelper
builder.Services.AddScoped<IImageHelper, ImageHelper>();
//inyectamos el converterHelper
builder.Services.AddScoped<IConverterHelper, ConverterHelper>();

var app = builder.Build();

//va con los seeders
SeedData(app);

void SeedData(WebApplication app)
{
    IServiceScopeFactory? scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (IServiceScope? scope = scopedFactory!.CreateScope())
    {
        SeedDb? service = scope.ServiceProvider.GetService<SeedDb>();
        service!.SeedAsync().Wait();
    }
}

//SeedData(app);
//void SeedData(WebApplication app)
//{
//    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
//    using var scope = scopedFactory!.CreateScope();
//    var service = scope.ServiceProvider.GetService<SeedDb>();
//    service!.SeedAsync().Wait();
//}

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