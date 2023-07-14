namespace CinemaApp.Presentation
{
    partial class FormFilm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.textBoxDiffusion = new System.Windows.Forms.TextBox();
            this.labelDiffusion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(554, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Movie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelFilm
            // 
            this.panelFilm.Location = new System.Drawing.Point(310, 35);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(622, 367);
            this.panelFilm.TabIndex = 8;
            // 
            // textBoxDiffusion
            // 
            this.textBoxDiffusion.Location = new System.Drawing.Point(12, 68);
            this.textBoxDiffusion.Multiline = true;
            this.textBoxDiffusion.Name = "textBoxDiffusion";
            this.textBoxDiffusion.Size = new System.Drawing.Size(292, 236);
            this.textBoxDiffusion.TabIndex = 9;
            // 
            // labelDiffusion
            // 
            this.labelDiffusion.AutoSize = true;
            this.labelDiffusion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDiffusion.Location = new System.Drawing.Point(58, 50);
            this.labelDiffusion.Name = "labelDiffusion";
            this.labelDiffusion.Size = new System.Drawing.Size(194, 15);
            this.labelDiffusion.TabIndex = 10;
            this.labelDiffusion.Text = "Click here for seeing date of movies";
            this.labelDiffusion.Click += new System.EventHandler(this.labelDiffusion_Click);
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(998, 463);
            this.Controls.Add(this.labelDiffusion);
            this.Controls.Add(this.textBoxDiffusion);
            this.Controls.Add(this.panelFilm);
            this.Controls.Add(this.label2);
            this.Name = "FormFilm";
            this.Text = "ShowBuzzFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Panel panelFilm;
        private TextBox textBoxDiffusion;
        private Label labelDiffusion;
    }
}