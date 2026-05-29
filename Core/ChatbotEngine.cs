using System;

namespace CyberChatbot.Core
{
    public class ChatbotEngine
    {
        private KeywordManager keywordManager = new KeywordManager();
        private MemoryManager memory = new MemoryManager();
        private SentimentDetector sentiment = new SentimentDetector();
        private RandomResponses randomResponses = new RandomResponses();

        private string currentTopic = "";

        public string ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Please enter a message.";

            input = input.ToLower();

            // 🧠 MEMORY
            if (input.Contains("my name is"))
            {
                memory.UserName = input.Replace("my name is", "").Trim();
                return $"Nice to meet you, {memory.UserName}. Stay safe online!";
            }

            if (input.Contains("i'm interested in"))
            {
                memory.Interest = input.Replace("i'm interested in", "").Trim();
                return $"Got it! I'll remember you're interested in {memory.Interest}.";
            }

            // 😊 SENTIMENT DETECTION
            string mood = sentiment.Detect(input);

            if (mood == "worried")
                return "It's okay to feel worried. Let me help you stay safe.\n\n" + HandleTopic(input);

            if (mood == "frustrated")
                return "No stress — I'll explain it simply.\n\n" + HandleTopic(input);

            // 🔁 CONVERSATION FLOW
            if (input.Contains("another tip") && currentTopic != "")
                return randomResponses.GetRandom(currentTopic);

            if (input.Contains("explain more"))
                return Explain(currentTopic);

            // 🧠 MAIN LOGIC
            return HandleTopic(input);
        }

        private string HandleTopic(string input)
        {
            string keywordResponse = keywordManager.Check(input);

            if (keywordResponse != null)
            {
                if (input.Contains("password")) currentTopic = "password";
                if (input.Contains("scam") || input.Contains("phishing")) currentTopic = "phishing";
                if (input.Contains("privacy")) currentTopic = "privacy";

                return keywordResponse;
            }

            if (input.Contains("phishing"))
            {
                currentTopic = "phishing";
                return randomResponses.Get("phishing");
            }

            if (input.Contains("password"))
            {
                currentTopic = "password";
                return keywordManager.PasswordTip();
            }

            if (input.Contains("privacy"))
            {
                currentTopic = "privacy";
                return keywordManager.PrivacyTip();
            }

            return "I’m not sure I understand. Try rephrasing.";
        }

        private string Explain(string topic)
        {
            switch (topic)
            {
                case "phishing":
                    return "Phishing is when attackers trick you into giving personal information like passwords or bank details.";
                case "password":
                    return "Strong passwords should be long, unique, and include symbols, numbers, and letters.";
                case "privacy":
                    return "Privacy means controlling who can see your personal information online.";
                default:
                    return "I don't have more info on that right now.";
            }
        }
    }
}