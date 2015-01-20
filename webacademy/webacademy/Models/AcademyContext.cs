using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webacademy.Models
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }
        [MinLength(1)]
        [MaxLength(50)]
        public string Desc { get; set; }
    }
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MinLength(1)]
        [MaxLength(50)]
        public string Alias { get; set; }
        [MinLength(1)]
        [MaxLength(50)]
        public string Email { get; set; }
    }
    public class AcademyContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}