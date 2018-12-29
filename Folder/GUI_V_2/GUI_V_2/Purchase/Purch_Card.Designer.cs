namespace GUI_V_2.Purchase
{
    partial class Purch_Card
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(389, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 81;
            this.label12.Text = "Год";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(312, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 80;
            this.label11.Text = "Месяц";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox4.Location = new System.Drawing.Point(388, 257);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(63, 29);
            this.comboBox4.TabIndex = 79;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox3.Location = new System.Drawing.Point(316, 257);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(42, 29);
            this.comboBox3.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(312, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 77;
            this.label10.Text = "Номер карты";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.textBox8.Location = new System.Drawing.Point(316, 193);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(173, 29);
            this.textBox8.TabIndex = 76;
            // 
            // Purch_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Name = "Purch_Card";
            this.Text = "Purch_Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
    }
}