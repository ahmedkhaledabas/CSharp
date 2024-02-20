using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal class AuditEntry
    {
        public int AuditEntryId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
