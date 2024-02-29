using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other

    }
    internal class Resource
    {
        public int ResourceId { get; set; }

        [Unicode(true)]
        [MinLength(50)]
        [Required]
        public string Name { get; set; }

        public ResourceType ResourceType { get; set; }

        [Unicode(false)]
        public string Url {  get; set; }

        public int CourseId { get; set; }
        //public Course Course { get; set; }
    }
}
