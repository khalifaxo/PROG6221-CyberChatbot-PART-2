using System;

namespace CyberChatbot.Core
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool Completed { get; set; }

        public TaskItem(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            Completed = false;
        }
    }
}