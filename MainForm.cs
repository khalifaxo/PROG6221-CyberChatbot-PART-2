using CyberChatbot.Core;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CyberChatbot.UI
{
    public partial class MainForm : Form
    {
        private ActivityLogger logger = new ActivityLogger();
        private ChatbotEngine bot;

        // QUIZ VARIABLES
        private int currentQuestion = 0;
        private int score = 0;

        private string[] questions =
        {
            "What is phishing?",
            "What makes a strong password?",
            "What is 2FA?",
            "What should you do with suspicious emails?",
            "What is malware?"
        };

        private string[][] options =
        {
            new string[] { "Fishing online", "Fake scam messages", "Gaming", "Shopping" },
            new string[] { "123456", "Your name", "Mix of letters and numbers", "Password123" },
            new string[] { "Two friends access", "Extra login security", "Email backup", "Firewall" },
            new string[] { "Open it", "Ignore safety", "Report it", "Forward it to friends" },
            new string[] { "Software that harms your PC", "Antivirus", "Browser", "Game app" }
        };

        private int[] answers = { 1, 2, 1, 2, 0 };

        public MainForm()
        {
            InitializeComponent();

            bot = new ChatbotEngine(logger);

            txtChat.AppendText("CyberChatbot Online...\n\n");
        }

        // ================= CHATBOT =================

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
            txtChat.AppendText("CyberChatbot Online...\n\n");
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

        // ================= ACTIVITY LOG =================

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtChat.AppendText("\n--- ACTIVITY LOG ---\n");

            foreach (var log in logger.GetLast10())
            {
                txtChat.AppendText(log + "\n");
            }

            txtChat.AppendText("--------------------\n\n");
        }

        // ================= QUIZ =================

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            score = 0;

            txtChat.AppendText("\nQuiz Started!\n");
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestion >= questions.Length)
            {
                txtChat.AppendText("\nQuiz Finished!\nFinal Score: " + score + "\n");
                MessageBox.Show("Final Score: " + score);

                logger.Log("Quiz completed with score: " + score);
                return;
            }

            txtChat.AppendText("\nQuestion: " + questions[currentQuestion] + "\n");

            btnA.Text = options[currentQuestion][0];
            btnB.Text = options[currentQuestion][1];
            btnC.Text = options[currentQuestion][2];
            btnD.Text = options[currentQuestion][3];

            logger.Log("Quiz question shown");
        }

        private void CheckAnswer(int selected)
        {
            if (selected == answers[currentQuestion])
            {
                score++;
                txtChat.AppendText("Correct!\n");
                logger.Log("Quiz correct answer");
            }
            else
            {
                txtChat.AppendText("Wrong!\n");
                logger.Log("Quiz wrong answer");
            }

            currentQuestion++;
            LoadQuestion();
        }

        private void btnA_Click(object sender, EventArgs e) => CheckAnswer(0);
        private void btnB_Click(object sender, EventArgs e) => CheckAnswer(1);
        private void btnC_Click(object sender, EventArgs e) => CheckAnswer(2);
        private void btnD_Click(object sender, EventArgs e) => CheckAnswer(3);
    }
}