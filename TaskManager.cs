using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberChatbot.Core
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private ActivityLogger logger;

        public TaskManager(ActivityLogger log)
        {
            logger = log;
        }

        // ADD TASK
        public string AddTask(string title, string description)
        {
            TaskItem task = new TaskItem(title, description);
            tasks.Add(task);

            logger.Log("Task added: " + title);

            return $"Task added: {title}";
        }

        // VIEW TASKS
        public List<TaskItem> GetTasks()
        {
            return tasks;
        }

        // COMPLETE TASK
        public string CompleteTask(int index)
        {
            if (index < 0 || index >= tasks.Count)
                return "Invalid task index.";

            tasks[index].Completed = true;
            logger.Log("Task completed: " + tasks[index].Title);

            return "Task marked as completed.";
        }

        // DELETE TASK
        public string DeleteTask(int index)
        {
            if (index < 0 || index >= tasks.Count)
                return "Invalid task index.";

            logger.Log("Task deleted: " + tasks[index].Title);

            tasks.RemoveAt(index);

            return "Task deleted.";
        }
    }
}