using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPTimeTracker.Domain.Enums;

namespace JPTimeTracker.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProjectId { get; set; }

        public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Pending;

        // Relacionamento
        public Project? Project { get; set; }

        // Sessões de tempo (play/stop)
        public List<TaskSession> Sessions { get; set; } = new();

        // Tempo total computado
        public TimeSpan TotalTime => TimeSpan.FromSeconds(Sessions.Sum(s => s.Duration.TotalSeconds));

        // Métodos para play/stop
        public void Start()
        {
            if (Status == Enums.TaskStatus.InProgress) return;

            Status = Enums.TaskStatus.InProgress;
            Sessions.Add(new TaskSession { StartTime = DateTime.Now });
        }

        public void Stop()
        {
            if (Status != Enums.TaskStatus.InProgress) return;

            var current = Sessions.LastOrDefault(s => s.EndTime == null);
            if (current != null)
                current.EndTime = DateTime.Now;

            Status = Enums.TaskStatus.Pending;
        }
    }
}
