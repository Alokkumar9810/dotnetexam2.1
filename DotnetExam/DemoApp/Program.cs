using DemoApp.StudentInfo;
//creating object of DbContext which establish connection of database
var db = new StudentInfoDbContext();

if(args.Length == 0)
{   
    Console.WriteLine("Course NO\tName\tFees");

    //Displaying the data of all Students
    foreach(var c in db.Course) //foreach to display data of all rows in database 
        Console.WriteLine("{0, -6}{1, 12}{2, 8}", c.Id, c.name, c.fees);
}
else
{
    //Displaying the data of passed Students
    int cno = int.Parse(args[0]);
    var ccno = db.Course
                    .Where(p=>p.Id == cno)
                    .Include(p=> p.Student)
                    .FirstOrDefault();
    if( ccno != null)
    {
        Console.WriteLine("RollNo\tName\tAge\tGrade\tCourse");
        foreach(var st in ccno.Student) //foreach to display data of passed students  
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", st.Id, st.name, st.Age,st.grade, ccno.name); //displaying the data
    }


    
    
    
    
}
