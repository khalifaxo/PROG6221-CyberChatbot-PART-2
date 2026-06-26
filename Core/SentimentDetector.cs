using System;

namespace CyberChatbot.Core
{
    public class SentimentDetector
    {
        public string Detect(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") || input.Contains("scared"))
                return "negative";

            if (input.Contains("curious") || input.Contains("interested"))
                return "positive";

            if (input.Contains("frustrated"))
                return "negative";

            return "neutral";
        }
    }
}