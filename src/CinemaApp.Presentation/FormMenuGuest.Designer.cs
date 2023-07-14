namespace CinemaApp.Presentation
{
    partial class FormMenuGuest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelAbout);
            this.panel1.Controls.Add(this.labelNews);
            this.panel1.Controls.Add(this.labelHome);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 47);
            this.panel1.TabIndex = 3;
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
            this.labelNews.Location = new System.Drawing.Point(447, 11);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(42, 17);
            this.labelNews.TabIndex = 2;
            this.labelNews.Text = "News";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Black;
            this.labelHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHome.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHome.Location = new System.Drawing.Point(270, 11);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(43, 17);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // panelGuest
            // 
            this.panelGuest.Location = new System.Drawing.Point(221, 86);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(575, 223);
            this.panelGuest.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(432, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose a cinema";
            // 
            // FormMenuGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenuGuest";
            this.Text = "FormMenuGuest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelAbout;
        private Label labelNews;
        private Label labelHome;
        private Panel panelGuest;
        private Label label2;
    }
}