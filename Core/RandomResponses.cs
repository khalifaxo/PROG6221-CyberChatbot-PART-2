using System;
using System.Collections.Generic;

namespace CyberChatbot.Core
{
    public class RandomResponses
    {
        private Random rand = new Random();

        private Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>()
        {
            {
                "phishing",
                new List<string>()
                {
                    "Check email addresses carefully before clicking links.",
                    "Never share passwords via email or messages.",
                    "Look for urgent or threatening language in messages."
                }
            }
        };

        public string Get(string topic)
        {
            if (!responses.ContainsKey(topic))
                return "No tips available.";

            var list = responses[topic];
            return list[rand.Next(list.Count)];
        }

        public string GetRandom(string topic)
        {
            return Get(topic);
        }
    }
}