namespace CinemaApp.Presentation
{
    partial class FormMainAdmi
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
            this.labelbalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelModif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelbalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelModif);
            this.panel1.Location = new System.Drawing.Point(-61, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 38);
            this.panel1.TabIndex = 1;
            // 
            // labelbalance
            // 
            this.labelbalance.AutoSize = true;
            this.labelbalance.BackColor = System.Drawing.Color.Black;
            this.labelbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelbalance.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelbalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelbalance.Location = new System.Drawing.Point(659, 9);
            this.labelbalance.Name = "labelbalance";
            this.labelbalance.Size = new System.Drawing.Size(54, 17);
            this.labelbalance.TabIndex = 3;
            this.labelbalance.Text = "Balance";
            this.labelbalance.Click += new System.EventHandler(this.labelbalance_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CinemaApp";
            // 
            // LabelModif
            // 
            this.LabelModif.AutoSize = true;
            this.LabelModif.BackColor = System.Drawing.Color.Black;
            this.LabelModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelModif.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelModif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelModif.Location = new System.Drawing.Point(346, 9);
            this.LabelModif.Name = "LabelModif";
            this.LabelModif.Size = new System.Drawing.Size(81, 17);
            this.LabelModif.TabIndex = 2;
            this.LabelModif.Text = "Modification";
            this.LabelModif.Click += new System.EventHandler(this.LabelModif_Click);
            // 
            // FormMainAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainAdmi";
            this.Text = "FormMainAdmi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label LabelModif;
        private Label labelbalance;
    }
}