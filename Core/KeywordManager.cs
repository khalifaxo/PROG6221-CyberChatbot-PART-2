namespace CyberChatbot.Core
{
    public class KeywordManager
    {
        public string Check(string input)
        {
            input = input.ToLower();

            if (input.Contains("password"))
                return "Use strong, unique passwords with symbols and numbers.";

            if (input.Contains("scam"))
                return "Be careful of scams asking for personal details or money.";

            if (input.Contains("privacy"))
                return "Protect your privacy by adjusting account settings.";

            return null;
        }

        public string PasswordTip()
        {
            return "Tip: Use at least 12 characters with a mix of symbols, numbers, and letters.";
        }

        public string PrivacyTip()
        {
            return "Tip: Avoid sharing personal information publicly online.";
        }
    }
}