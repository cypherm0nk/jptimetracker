using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPTimeTracker.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Relacionamento 1:N
        public List<TaskItem> Tasks { get; set; } = new();
    }
}
