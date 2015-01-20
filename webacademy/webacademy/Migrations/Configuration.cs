namespace webacademy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using webacademy.Models;
    
    internal sealed class Configuration : DbMigrationsConfiguration<webacademy.Models.AcademyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(webacademy.Models.AcademyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Employee[] employees = new Employee[] 
            {
                new Employee(){Alias="Niranjan", Email="niranjan_awati@abc.com", Id=1},
                new Employee(){Alias="Hunny", Email="hunny_verma@abc.com", Id=2},
                new Employee(){Alias="Ebin", Email="ebin_ipe@abc.com", Id=3},
                new Employee(){Alias="Ruchira", Email="ruuchira_agarwal@abc.com", Id=4},
                new Employee(){Alias="Deepanchal", Email="deepanchal_sharma@abc.com", Id=5}
            };
            Skill[] skills = new Skill[] 
            {
                new Skill(){Title="Programming"},
                new Skill(){Title="Domain"},
                new Skill(){Title = "Process and management"},
                new Skill(){Title="Soft"}
            };
            Array.ForEach(employees, x => context.Employees.AddOrUpdate(x));
            context.SaveChanges();
            Array.ForEach(skills, x => context.Skills.AddOrUpdate(x));
            context.SaveChanges();

        }
    }
}
