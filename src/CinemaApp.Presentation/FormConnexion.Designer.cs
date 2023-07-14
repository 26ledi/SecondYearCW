namespace CinemaApp.Presentation
{
    partial class FormConnexion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGoconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(323, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 309);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.buttonGoconnexion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userlabel);
            this.panel2.Controls.Add(this.PasswordtextBox);
            this.panel2.Controls.Add(this.UserNametextBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 303);
            this.panel2.TabIndex = 1;
            // 
            // buttonGoconnexion
            // 
            this.buttonGoconnexion.Location = new System.Drawing.Point(133, 216);
            this.buttonGoconnexion.Name = "buttonGoconnexion";
            this.buttonGoconnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonGoconnexion.TabIndex = 4;
            this.buttonGoconnexion.Text = "Go";
            this.buttonGoconnexion.UseVisualStyleBackColor = true;
            this.buttonGoconnexion.Click += new System.EventHandler(this.buttonGoconnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userlabel.Location = new System.Drawing.Point(86, 71);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(60, 15);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "Username";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordtextBox.Location = new System.Drawing.Point(83, 162);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(176, 23);
            this.PasswordtextBox.TabIndex = 1;
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNametextBox.Location = new System.Drawing.Point(83, 88);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(176, 23);
            this.UserNametextBox.TabIndex = 0;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(1012, 456);
            this.Controls.Add(this.panel1);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonGoconnexion;
        private Label label1;
        private Label userlabel;
        private TextBox PasswordtextBox;
        private TextBox UserNametextBox;
    }
}