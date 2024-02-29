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
    internal class Course
    {
        public int CourseId { get; set; }

        [Unicode(true)]
        public string? Desc { get; set; }

        public DateTime EndDate { get; set; }

        [Unicode(true)]
        [MinLength(80)]
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime StartDate { get; set; }

        //public int StudentId { get; set; }
        //public Student Student { get; set; }
        public ICollection<Student> Students { get; set; }

        public List<Resource> Resources { get; set; }

        public ICollection<Homework> Homeworks { get; set; }


        public override string ToString()
        {
            return $"Course : {Name} \n ID : {CourseId} \n Start Date : {StartDate} \n End Date : {EndDate} \n Price : ${Price} \n----\n";
        }

        
    }

}
