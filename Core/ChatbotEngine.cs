using System;

namespace CyberChatbot.Core
{
    public class ChatbotEngine
    {
        private KeywordManager keywords = new KeywordManager();
        private RandomResponses responses = new RandomResponses();
        private SentimentDetector sentiment = new SentimentDetector();
        private MemoryManager memory = new MemoryManager();
        private ActivityLogger logger;
        private TaskManager tasks;

        public ChatbotEngine(ActivityLogger logger)
        {
            this.logger = logger;
            this.tasks = new TaskManager(logger);
        }

        public string ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Please enter a valid message.";

            string text = input.ToLower();

            logger.Log("User: " + input);

            // ================= TASK SYSTEM =================
            if (text.Contains("add task"))
            {
                string task = input.ToLower().Replace("add task", "").Trim();

                if (string.IsNullOrWhiteSpace(task))
                    return "Please specify what task to add.";

                return tasks.AddTask(task, "Cybersecurity task");
            }

            if (text.Contains("show tasks"))
            {
                var list = tasks.GetTasks();

                if (list.Count == 0)
                    return "No tasks found.";

                string output = "Tasks:\n";

                for (int i = 0; i < list.Count; i++)
                {
                    output += $"{i + 1}. {list[i].Title} ({(list[i].Completed ? "Done" : "Pending")})\n";
                }

                return output;
            }

            // ================= MEMORY =================
            if (text.Contains("my name is"))
            {
                string name = input.ToLower().Replace("my name is", "").Trim();
                memory.Save("name", name);

                logger.Log("Saved name: " + name);

                return $"Nice to meet you, {name}. I’ll remember that.";
            }

            // ================= QUIZ TRIGGER =================
            if (text.Contains("quiz"))
            {
                logger.Log("Quiz requested");
                return "Open the Quiz section to start the cybersecurity test.";
            }

            // ================= SENTIMENT =================
            string sent = sentiment.Detect(input);

            if (sent == "negative")
            {
                logger.Log("Negative sentiment detected");
                return "I understand. Stay calm — I’ll help you stay safe online.";
            }

            // ================= KEYWORDS =================
            string keyword = keywords.DetectKeyword(input);

            if (!string.IsNullOrEmpty(keyword))
            {
                string response = responses.GetResponse(keyword);
                logger.Log("Keyword: " + keyword);
                return response;
            }

            logger.Log("Default response");
            return "Try: add task, show tasks, quiz, or ask about phishing/password safety.";
        }
    }
}