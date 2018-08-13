using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(20)]
        [Required]
        public string Firstname { get; set; }

        [StringLength(20)]
        [Required]
        public string Surname { get; set; }

        [StringLength(20)]
        [Required]
        public string Subject { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage ="Please enter a mark between 0 and 100")]
        public int Mark { get; set; }

        //[DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        public string ImageURL { get; set; }

    }

    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}