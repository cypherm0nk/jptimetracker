using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPTimeTracker.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int DurationMinutes { get; set; }
        public bool Completed { get; set; }

        public Project Project { get; set; }
    }
}
