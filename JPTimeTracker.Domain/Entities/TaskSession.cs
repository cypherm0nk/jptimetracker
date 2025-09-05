using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPTimeTracker.Domain.Entities
{
    public class TaskSession
    {
        public int Id { get; set; }
        public int TaskItemId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public TimeSpan Duration =>
            EndTime.HasValue
                ? EndTime.Value - StartTime
                : TimeSpan.Zero;

        public TaskItem? Task { get; set; }
    }
}
