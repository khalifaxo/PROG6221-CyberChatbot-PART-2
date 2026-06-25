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
                string path = System.IO.Path.Combine("Assets", "greeting.wav");

                if (System.IO.File.Exists(path))
                {
                    System.Media.SoundPlayer player =
                        new System.Media.SoundPlayer(path);

                    player.Play();
                }
                else
                {
                    MessageBox.Show("Voice file not found in Assets folder.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing voice: " + ex.Message);
            }
        }
    }
}
