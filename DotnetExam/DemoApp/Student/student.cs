global using Microsoft.EntityFrameworkCore;
namespace DemoApp.StudentInfo;

public class student
{
    
    public int Id { get; set; } //According to convention primary key must be id

    public string name { get; set; }
     
    public int Age { get; set; }

    public string grade { get; set; }

    
}