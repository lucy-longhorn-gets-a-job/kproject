using sp19team5project.Models;
using Microsoft.EntityFrameworkCore;

namespace sp19team5project.DAL
{
      public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //You need one db set for each model class. For example:
    public DbSet<Application> Applications { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Company> Companys { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Major> Majors { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<PositionDetail> PositionDetails { get; set; }


    }
}