using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    internal class Student
    {
        public int StudentID { get; set; }

        public DateOnly BirthDay {  get; set; } 

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }
    }
}
