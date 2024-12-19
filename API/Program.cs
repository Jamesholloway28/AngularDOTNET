using System.Security.Cryptography;
using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

//middleware
// Configure the HTTP request pipeline.


app.MapControllers();
//end middleware


app.Run();
