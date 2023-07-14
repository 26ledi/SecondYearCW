namespace CinemaApp.Presentation
{
    partial class FormFilmBuy
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCatego = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxNbrticket = new System.Windows.Forms.NumericUpDown();
            this.ShowbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBuyShow = new System.Windows.Forms.Button();
            this.comboBoxSess = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCash = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxNbrticket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of place";
            // 
            // comboBoxCatego
            // 
            this.comboBoxCatego.FormattingEnabled = true;
            this.comboBoxCatego.Items.AddRange(new object[] {
            "VIP",
            "Middle",
            "Economic"});
            this.comboBoxCatego.Location = new System.Drawing.Point(137, 252);
            this.comboBoxCatego.Name = "comboBoxCatego";
            this.comboBoxCatego.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCatego.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(273, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Ticket";
            // 
            // BoxNbrticket
            // 
            this.BoxNbrticket.Location = new System.Drawing.Point(395, 250);
            this.BoxNbrticket.Name = "BoxNbrticket";
            this.BoxNbrticket.Size = new System.Drawing.Size(120, 23);
            this.BoxNbrticket.TabIndex = 3;
            // 
            // ShowbPrice
            // 
            this.ShowbPrice.Location = new System.Drawing.Point(415, 351);
            this.ShowbPrice.Multiline = true;
            this.ShowbPrice.Name = "ShowbPrice";
            this.ShowbPrice.Size = new System.Drawing.Size(100, 25);
            this.ShowbPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(353, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(791, 246);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBuyShow
            // 
            this.buttonBuyShow.Location = new System.Drawing.Point(538, 350);
            this.buttonBuyShow.Name = "buttonBuyShow";
            this.buttonBuyShow.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyShow.TabIndex = 7;
            this.buttonBuyShow.Text = "Buy";
            this.buttonBuyShow.UseVisualStyleBackColor = true;
            this.buttonBuyShow.Click += new System.EventHandler(this.buttonBuyShow_Click);
            // 
            // comboBoxSess
            // 
            this.comboBoxSess.FormattingEnabled = true;
            this.comboBoxSess.Items.AddRange(new object[] {
            "Night",
            "Evening",
            "Morning"});
            this.comboBoxSess.Location = new System.Drawing.Point(636, 246);
            this.comboBoxSess.Name = "comboBoxSess";
            this.comboBoxSess.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSess.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(555, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Session";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(879, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(682, 350);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Click here for seeing available places";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(-3, 18);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(261, 83);
            this.textBoxPlace.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(465, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cashiers";
            // 
            // comboBoxCash
            // 
            this.comboBoxCash.FormattingEnabled = true;
            this.comboBoxCash.Location = new System.Drawing.Point(429, 18);
            this.comboBoxCash.Name = "comboBoxCash";
            this.comboBoxCash.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCash.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-3, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Click here for seeing the unit price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(202, 151);
            this.textBoxUnit.Multiline = true;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(56, 18);
            this.textBoxUnit.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(264, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "$";
            // 
            // FormFilmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaApp.Presentation.Properties.Resources.photo_2023_04_09_21_28_09;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSess);
            this.Controls.Add(this.buttonBuyShow);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowbPrice);
            this.Controls.Add(this.BoxNbrticket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCatego);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormFilmBuy";
            this.Text = "ShowBuzzBuy";
            this.Load += new System.EventHandler(this.FormFilmBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxNbrticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCatego;
        private Label label2;
        private NumericUpDown BoxNbrticket;
        private TextBox ShowbPrice;
        private Label label3;
        private Button buttonOk;
        private Button buttonBuyShow;
        private ComboBox comboBoxSess;
        private Label label4;
        private Button buttonLogout;
        private Button buttonReset;
        private Label label5;
        private TextBox textBoxPlace;
        private Label label6;
        private ComboBox comboBoxCash;
        private Label label7;
        private TextBox textBoxUnit;
        private Label label8;
    }
}