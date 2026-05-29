namespace CyberChatbot.Core
{
    public class SentimentDetector
    {
        public string Detect(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") || input.Contains("scared"))
                return "worried";

            if (input.Contains("frustrated") || input.Contains("confused"))
                return "frustrated";

            if (input.Contains("curious"))
                return "curious";

            return "neutral";
        }
    }
}