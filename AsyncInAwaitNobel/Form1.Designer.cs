namespace Nobel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.poljeRezultati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vnosLeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vnosPodrocja = new System.Windows.Forms.CheckedListBox();
            this.gumbPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregledovanje baze Nobel";
            // 
            // poljeRezultati
            // 
            this.poljeRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poljeRezultati.Location = new System.Drawing.Point(483, 79);
            this.poljeRezultati.Multiline = true;
            this.poljeRezultati.Name = "poljeRezultati";
            this.poljeRezultati.Size = new System.Drawing.Size(396, 334);
            this.poljeRezultati.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(293, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vnesite leto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 334);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vnosLeto
            // 
            this.vnosLeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnosLeto.Location = new System.Drawing.Point(288, 119);
            this.vnosLeto.Name = "vnosLeto";
            this.vnosLeto.Size = new System.Drawing.Size(159, 35);
            this.vnosLeto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(274, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izberite področje";
            // 
            // vnosPodrocja
            // 
            this.vnosPodrocja.CheckOnClick = true;
            this.vnosPodrocja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnosPodrocja.FormattingEnabled = true;
            this.vnosPodrocja.Items.AddRange(new object[] {
            "Kemija",
            "Fizika",
            "Medicina",
            "Mir",
            "Literatura",
            "Ekonomija"});
            this.vnosPodrocja.Location = new System.Drawing.Point(288, 229);
            this.vnosPodrocja.Name = "vnosPodrocja";
            this.vnosPodrocja.Size = new System.Drawing.Size(174, 184);
            this.vnosPodrocja.TabIndex = 6;
            // 
            // gumbPrikazi
            // 
            this.gumbPrikazi.BackColor = System.Drawing.Color.Lime;
            this.gumbPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPrikazi.ForeColor = System.Drawing.Color.Black;
            this.gumbPrikazi.Location = new System.Drawing.Point(314, 419);
            this.gumbPrikazi.Name = "gumbPrikazi";
            this.gumbPrikazi.Size = new System.Drawing.Size(123, 41);
            this.gumbPrikazi.TabIndex = 7;
            this.gumbPrikazi.Text = "Prikaži";
            this.gumbPrikazi.UseVisualStyleBackColor = false;
            this.gumbPrikazi.Click += new System.EventHandler(this.prikaziKlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(891, 469);
            this.Controls.Add(this.gumbPrikazi);
            this.Controls.Add(this.vnosPodrocja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vnosLeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poljeRezultati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Nobel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poljeRezultati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox vnosLeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox vnosPodrocja;
        private System.Windows.Forms.Button gumbPrikazi;
    }
}

