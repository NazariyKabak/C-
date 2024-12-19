using Microsoft.EntityFrameworkCore;
using WebApplication1Prac3.Models;

namespace WebApplication1Prac3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}