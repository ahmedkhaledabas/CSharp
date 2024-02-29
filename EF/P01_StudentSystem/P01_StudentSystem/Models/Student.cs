using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }

        public DateTime? BirthDay {  get; set; }
        [Unicode(true)]
        [MinLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string? PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<Homework> Homeworks { get; set; }

        public override string ToString()
        {
            return $" Name : {Name} \n Phone : {PhoneNumber} \n BirthDay : {BirthDay} \n RegisterOn : {RegisteredOn} \n---\n";
        }

        
    }
}
