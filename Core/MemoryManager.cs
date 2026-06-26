using System.Collections.Generic;

namespace CyberChatbot.Core
{
    public class MemoryManager
    {
        private Dictionary<string, string> memory =
            new Dictionary<string, string>();

        public void Save(string key, string value)
        {
            memory[key] = value;
        }

        public string Get(string key)
        {
            return memory.ContainsKey(key) ? memory[key] : "";
        }

        public bool Exists(string key)
        {
            return memory.ContainsKey(key);
        }
    }
}