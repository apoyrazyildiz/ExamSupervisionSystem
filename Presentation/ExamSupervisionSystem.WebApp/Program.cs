using ExamSupervisionSystem.Application.Containers.MicrosoftIOC;
using ExamSupervisionSystem.Persistence.Concrete.EntityFrameworkCore.Contexts;
using ExamSupervisionSystem.Persistence.Containers.MicrosoftIOC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration(builder.Configuration, "ExamSupervisionSystem.WebApp");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<EfDbContext>();
context.Database.Migrate();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();