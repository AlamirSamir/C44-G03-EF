using Assignment_03_EF.Models;

namespace Assignment_03_EF.Data
{
    public static class CRUDOperations
    {
        public static void PerformCRUDAndTestRelations()
        {
            Console.WriteLine("--- Starting Full EF Core Operations (CRUD & Relations Test) ---");

            using (var context = new ITIContext())
            {
                if (!context.Departments.Any() || !context.Instructors.Any() || !context.Courses.Any())
                {
                    Console.WriteLine("\n--- Seeding Initial Data ---");

                    var deptSD = new Department { Name = "Software Development", HiringDate = DateTime.Now.AddYears(-5) };
                    var topicDB = new Topic { Name = "Database Systems" };
                    var instAhmed = new Instructor { Name = "Dr. Ahmed", Salary = 50000, Adress = "Cairo" };

                    context.Topics.Add(topicDB);
                    context.Instructors.Add(instAhmed);

                    context.Departments.Add(deptSD);
                    context.SaveChanges();

                    deptSD.Ins_ID = instAhmed.ID;

                    instAhmed.Dept_ID = deptSD.ID;

                    context.SaveChanges();


                    var courseCS = new Course { Name = "C# Programming", Duration = 80, Top_ID = topicDB.ID, Description = "Covers C# language fundamentals and advanced topics." };
                    context.Courses.Add(courseCS);
                    context.SaveChanges();

                    var studentSara = new Student { FName = "Sara", LName = "Ali", Address = "Giza", Dep_Id = deptSD.ID, Age = 22 };
                    context.Students.Add(studentSara);
                    context.SaveChanges();

                    context.Stud_Courses.Add(new Stud_Course { Stud_ID = studentSara.ID, Course_ID = courseCS.ID, Grade = 95 });
                    context.Course_Insts.Add(new Course_Inst { Inst_ID = instAhmed.ID, Course_ID = courseCS.ID, Evaluate = 5 });
                    context.SaveChanges();

                    Console.WriteLine("✅ Seeding Complete. Data is linked.");
                }
            }
        }
    }
}