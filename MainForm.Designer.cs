namespace CyberChatbot.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVoice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVoice = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtChat
            this.txtChat.Location = new System.Drawing.Point(12, 12);
            this.txtChat.Size = new System.Drawing.Size(760, 300);
            this.txtChat.ReadOnly = true;

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(12, 320);
            this.txtInput.Size = new System.Drawing.Size(500, 23);

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(520, 318);
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(600, 318);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnVoice
            this.btnVoice.Location = new System.Drawing.Point(680, 318);
            this.btnVoice.Text = "Voice";
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVoice);
            this.Text = "Cybersecurity Chatbot";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}