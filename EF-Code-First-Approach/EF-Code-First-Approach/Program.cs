// See https://aka.ms/new-console-template for more information
using EF_Code_First_Approach.Services;
using EF_Code_First_Approach.Models;

Console.WriteLine("Hello, World!");

// To generate the database:
// Open Package Manager Console
// Execute the command: Add-Migration FirstMigration => this will genertae the classes that create the database
// Execute the command: Update-Database => this will let the system create the database

LMSContext context = new LMSContext();
LmsServie service = new LmsServie(context);

//var cs = service.GetAllCategories();
//foreach (var c in cs)
//{
//    Console.WriteLine(c.Name);
//}

//cs = service.GetAllCategoriesWithCourses();
//foreach (var c in cs)
//{
//    Console.WriteLine(c.Name + " - " + c.Courses.Count());
//}

var t = service.GetGradesOfCourse(1);
foreach (var c in t)
{
    Console.WriteLine(c.Id + " - " + c.Grade);
}



//Category cat = new Category();
//cat.Name = "Computer security";
//cat.Description = "Computer Security Category";
//cat.Courses = new List<Course>();
//cat.Courses.Add(new Course() { Name = "CISA", Description = "Certified Information Systems Auditors" });
//cat.Courses.Add(new Course() { Name = "CCSP", Description = "Certified Cloud Security Professional" });
//service.AddCategory(cat);

//service.DeleteCategory(5);

//var s = service.GetStudentById(1);
//Console.WriteLine(s.Name);

//var l = service.GetNumOfStudentsinEachCity();
//foreach (var city in l)
//{
//    Console.WriteLine(city.Item1 + " " + city.Item2);   
//}


//service.DeleteStudentById(2);


