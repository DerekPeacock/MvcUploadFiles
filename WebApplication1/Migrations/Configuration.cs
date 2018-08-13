namespace WebApplication1.Migrations
{
    using System.Data.Entity.Migrations;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.StudentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication1.Models.StudentDbContext";
        }

        protected override void Seed(WebApplication1.Models.StudentDbContext context)
        {
            context.Students.AddOrUpdate(i => i.ID,
                new Student
                {
                    ID = 1,
                    Firstname = "David",
                    Surname = "Smith",
                    Subject = "GCSE ICT",
                    Mark = 67
                },
                new Student
                {
                    ID = 2,
                    Firstname = "Anita",
                    Surname = "Rhani",
                    Subject = "GCSE English",
                    Mark = 57
                },
                    new Student
                    {
                        ID = 3,
                        Firstname = "George",
                        Surname = "Robson",
                        Subject = "GCSE Maths",
                        Mark = 87
                    },
                    new Student
                    {
                        ID = 4,
                        Firstname = "Veena",
                        Surname = "Ralhan",
                        Subject = "Computing",
                        Mark = 33
                    }
                );
        }
    }
}
