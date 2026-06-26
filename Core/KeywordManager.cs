using System.Collections.Generic;

namespace CyberChatbot.Core
{
    public class KeywordManager
    {
        public string DetectKeyword(string input)
        {
            input = input.ToLower();

            if (input.Contains("password"))
                return "password";

            if (input.Contains("phishing"))
                return "phishing";

            if (input.Contains("privacy"))
                return "privacy";

            return "";
        }
    }
}