using System;
using System.Collections.Generic;

namespace CyberChatbot.Core
{
    public class RandomResponses
    {
        private Random rand = new Random();

        private Dictionary<string, List<string>> responses =
            new Dictionary<string, List<string>>()
        {
            {
                "phishing",
                new List<string>
                {
                    "Never click suspicious links.",
                    "Always verify email senders.",
                    "Report phishing attempts immediately."
                }
            },

            {
                "password",
                new List<string>
                {
                    "Use strong unique passwords.",
                    "Enable 2FA for extra security.",
                    "Never reuse passwords across sites."
                }
            }
        };

        public string GetResponse(string keyword)
        {
            if (responses.ContainsKey(keyword))
            {
                var list = responses[keyword];
                return list[rand.Next(list.Count)];
            }

            return "";
        }
    }
}