namespace CinemaApp.Presentation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelSignIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.labelAbout);
            this.panel1.Controls.Add(this.labelNews);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 39);
            this.panel1.TabIndex = 0;
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.BackColor = System.Drawing.Color.Black;
            this.labelSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignIn.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSignIn.Location = new System.Drawing.Point(885, 11);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(55, 17);
            this.labelSignIn.TabIndex = 5;
            this.labelSignIn.Text = "Sign Up";
            this.labelSignIn.Click += new System.EventHandler(this.labelSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CinemaApp";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Black;
            this.labelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogin.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogin.Location = new System.Drawing.Point(963, 11);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 17);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Black;
            this.labelAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAbout.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAbout.Location = new System.Drawing.Point(628, 11);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(44, 17);
            this.labelAbout.TabIndex = 3;
            this.labelAbout.Text = "About";
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.BackColor = System.Drawing.Color.Black;
            this.labelNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNews.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNews.Location = new System.Drawing.Point(472, 11);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(42, 17);
            this.labelNews.TabIndex = 2;
            this.labelNews.Text = "News";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Black;
            this.labelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMenu.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMenu.Location = new System.Drawing.Point(308, 11);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(42, 17);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "W  e  l  c  o  m  e   T  o ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label labelLogin;
        private Label labelAbout;
        private Label labelNews;
        private Label labelMenu;
        private Label label1;
        private Label label2;
        private Label labelSignIn;
    }
}