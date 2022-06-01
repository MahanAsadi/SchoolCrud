using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int  Age { get; set; }
    }

    public class DemoContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
        
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}
