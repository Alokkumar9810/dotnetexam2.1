global using Microsoft.EntityFrameworkCore;
namespace DemoApp.StudentInfo;

public class crs
{
   
    public int Id { get; set; } //According to convention primary key must be id

    public string name { get; set; }
     
    public int fees { get; set; }

    public DbSet<student> Student { get; set; }

    
}