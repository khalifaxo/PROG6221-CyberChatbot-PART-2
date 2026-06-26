using System;
using System.Collections.Generic;

namespace CyberChatbot.Core
{
    public class ActivityLogger
    {
        private List<string> logs = new List<string>();

        public void Log(string message)
        {
            logs.Add($"{DateTime.Now}: {message}");
        }

        public List<string> GetLast10()
        {
            int start = Math.Max(0, logs.Count - 10);
            return logs.GetRange(start, logs.Count - start);
        }
    }
}