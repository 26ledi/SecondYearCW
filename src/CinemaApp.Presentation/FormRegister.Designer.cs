namespace CinemaApp.Presentation
{
    partial class FormRegister
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGoconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.textBoxEntryPwd = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.textBoxEntryPwd);
            this.panel2.Controls.Add(this.textBoxEntry);
            this.panel2.Controls.Add(this.buttonGoconnexion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userlabel);
            this.panel2.Location = new System.Drawing.Point(288, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 303);
            this.panel2.TabIndex = 2;
            // 
            // buttonGoconnexion
            // 
            this.buttonGoconnexion.Location = new System.Drawing.Point(125, 192);
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
            this.label1.Location = new System.Drawing.Point(140, 135);
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
            this.userlabel.Location = new System.Drawing.Point(140, 77);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(60, 15);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "Username";
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Location = new System.Drawing.Point(108, 100);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.Size = new System.Drawing.Size(124, 23);
            this.textBoxEntry.TabIndex = 5;
            // 
            // textBoxEntryPwd
            // 
            this.textBoxEntryPwd.Location = new System.Drawing.Point(108, 153);
            this.textBoxEntryPwd.Name = "textBoxEntryPwd";
            this.textBoxEntryPwd.Size = new System.Drawing.Size(124, 23);
            this.textBoxEntryPwd.TabIndex = 6;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.panel2);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button buttonGoconnexion;
        private Label label1;
        private Label userlabel;
        private TextBox textBoxEntry;
        private TextBox textBoxEntryPwd;
    }
}