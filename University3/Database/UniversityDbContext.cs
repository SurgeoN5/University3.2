using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using University3.Classes;

namespace University3.Database;

public class UniversityDbContext : DbContext
{
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<AcademicDeficiencies> AcademicDeficiencies { get; set; }
    public DbSet<FormOfReport>  FormOfReports { get; set; }
    public DbSet<Groups> Groups { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<Roles>  Roles { get; set; }
    public DbSet<Semestr>  Semestrs { get; set; }
    public DbSet<Statement>  Statements { get; set; }
    public DbSet<TeacherWorkload> TeacherWorkloads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Env.Load();
        
        string connectionString = Env.GetString("CONNECTION_STRING");
        
        optionsBuilder.UseNpgsql(connectionString);
    }

}