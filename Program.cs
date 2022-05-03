using WebApplication1.DataAccess;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);



builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddDbContext<UniversityDbContext>(options =>
        options.UseSqlServer(builder.Configuration["Data:UniversityLocal:ConnectionStrings"]));
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<UniversityDbContext>();
    dbContext.Database.EnsureCreated();
}


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
    pattern: "{controller=Home}/{action=FrontPage}/{id?}");

app.Run();
