using System;
using System.Windows.Forms;
using CyberChatbot.Core;

namespace CyberChatbot.UI
{
    public partial class MainForm : Form
    {
        private ChatbotEngine bot = new ChatbotEngine();

        public MainForm()
        {
            InitializeComponent();
            txtChat.AppendText("CyberChatbot Online...\n\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
                return;

            txtChat.AppendText("You: " + input + "\n");

            string response = bot.ProcessInput(input);

            txtChat.AppendText("Bot: " + response + "\n\n");

            txtInput.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChat.Clear();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player =
                    new System.Media.SoundPlayer("Assets/greeting.wav");

                player.Play();
            }
            catch
            {
                MessageBox.Show("Voice file not found.");
            }
        }
    }
}