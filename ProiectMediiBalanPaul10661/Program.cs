using Microsoft.EntityFrameworkCore;
using ProiectMediiBalanPaul10661.Data;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ClinicDB");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ClinicContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.MapGet("/", () => Results.Redirect("/Index"));

app.Run();
