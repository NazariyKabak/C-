using Microsoft.EntityFrameworkCore;
using WebApplication1Prac3.Data;

var builder = WebApplication.CreateBuilder(args);

// Підключення до бази даних
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Додаємо контролери
builder.Services.AddControllers();

// Додаємо Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Налаштування Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Підключення контролерів
app.MapControllers();

app.Run();