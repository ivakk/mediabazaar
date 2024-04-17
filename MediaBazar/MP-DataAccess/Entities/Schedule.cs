using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_and_B
{
    internal class Schedule
    {
        public int UserId { get; private set; }
        public List<Task> Tasks { get; private set; }

        public Schedule(int userId)
        {
            UserId = userId;
            Tasks = new List<Task>();
        }

        // Loads tasks for this user from the database
        /*public void LoadTasks(TaskDataAccess taskDataAccess)
        {
            try
            {
                Tasks = taskDataAccess.GetTasksForUser(UserId);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them, alert the user, etc.)
                Console.WriteLine("Error loading tasks: " + ex.Message);
            }
        }

        // Adds a new task for this user
        public void AddTask(Task newTask, TaskDataAccess taskDataAccess)
        {
            // Basic validation for the new task
            if (string.IsNullOrEmpty(newTask.Description))
            {
                throw new InvalidOperationException("Task description cannot be empty.");
            }

            try
            {
                taskDataAccess.AddTaskForUser(newTask);
                Tasks.Add(newTask); // Optionally, add to the local list without reloading all tasks
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error adding task: " + ex.Message);
            }
        }

        // Marks a specified task as completed
        public void MarkTaskAsCompleted(int taskId, TaskDataAccess taskDataAccess)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                try
                {
                    taskDataAccess.MarkTaskAsComplete(taskId);
                    task.AccomplishedDate = DateTime.Now; // Update the local task object
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error marking task as completed: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }*/

        // Additional methods as needed, such as updating or removing tasks
    }

}
