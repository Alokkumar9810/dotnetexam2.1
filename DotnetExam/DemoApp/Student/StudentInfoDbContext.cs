global using Microsoft.EntityFrameworkCore;

namespace DemoApp.StudentInfo;

public class StudentInfoDbContext : DbContext
{
    //collection of all entities in the context that can be queried from the database of a given type
    public DbSet<student> Student { get; set; }

    public DbSet<crs> Course { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Providing path nad name of database
        optionsBuilder.UseSqlServer("Server=(localdb)\\DACIIT;Database=student");

        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Entity linked with table using Fluent API
        modelBuilder.Entity<student>()
            .ToTable("student")
            .Property(p => p.Id)
            .HasColumnName("rollno"); // Primary Key mapped with Column 
        modelBuilder.Entity<crs>()
            .ToTable("course")
            .Property(p => p.Id)
            .HasColumnName("courseid");
        
    }
}