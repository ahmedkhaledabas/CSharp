using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Model
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string PName { get; set; }

        public DateTime DeadLine { get; set; }

        public Employee Employee { get; set; }
    }
}
