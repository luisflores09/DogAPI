using DogAPI.Data;
using Microsoft.EntityFrameworkCore;
// using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Env.Load();

// builder.Configuration.AddEnvironmentVariables();
var sqlConnection = builder.Configuration.GetConnectionString("DogAPI-SqlDb");

// var sqlConnection = builder.Configuration["ConnectionStrings:DogAPI:SqlDb"];

// var connectionString = $"Host={Env.GetString("DB_HOST")};" +
//                        $"Port={Env.GetString("DB_PORT")};" +
//                        $"Database={Env.GetString("DB_NAME")};" +
//                        $"Username={Env.GetString("DB_USER")};" +
//                        $"Password={Env.GetString("DB_PASSWORD")}";
// builder.Services.AddDbContext<DogDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<DogDbContext>(options =>
    options.UseSqlServer(sqlConnection));
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.Run();
