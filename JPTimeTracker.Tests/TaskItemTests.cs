using JPTimeTracker.Domain.Entities;
using System;

namespace JPTimeTracker.Tests
{
    public class TaskItemTests
    {
        [Fact]
        public void StartAndStop_ShouldAccumulateTime()
        {
            // Arrange
            var task = new TaskItem { Name = "Test Task" };

            // Act
            task.Start();
            System.Threading.Thread.Sleep(100); // simula tempo rodando
            task.Stop();

            // Assert
            Assert.Equal(Domain.Enums.TaskStatus.Pending, task.Status);
            Assert.True(task.TotalTime.TotalMilliseconds > 0);
        }
    }
}