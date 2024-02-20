using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Task
    {
        public int Id { get; set; }

        public string? Desc { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }
    }
}
