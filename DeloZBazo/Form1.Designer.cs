namespace DeloZBazo
{
    partial class Okno
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
            this.ocena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idFilma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.novaOcena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.potrdi = new System.Windows.Forms.Button();
            this.prikazPodatkov = new System.Windows.Forms.DataGridView();
            this.prikazPodatkov2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPodatkov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPodatkov2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaži filme, z oceno večjo ali enako:";
            // 
            // ocena
            // 
            this.ocena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocena.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ocena.Location = new System.Drawing.Point(18, 98);
            this.ocena.Name = "ocena";
            this.ocena.Size = new System.Drawing.Size(100, 26);
            this.ocena.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(18, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "DELO Z BAZO FILMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(384, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spremeni oceno filma z id";
            // 
            // idFilma
            // 
            this.idFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idFilma.Location = new System.Drawing.Point(605, 59);
            this.idFilma.Name = "idFilma";
            this.idFilma.Size = new System.Drawing.Size(100, 26);
            this.idFilma.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(384, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "na";
            // 
            // novaOcena
            // 
            this.novaOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.novaOcena.Location = new System.Drawing.Point(419, 95);
            this.novaOcena.Name = "novaOcena";
            this.novaOcena.Size = new System.Drawing.Size(100, 26);
            this.novaOcena.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(525, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 9;
            // 
            // potrdi
            // 
            this.potrdi.AutoSize = true;
            this.potrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potrdi.Location = new System.Drawing.Point(388, 147);
            this.potrdi.Name = "potrdi";
            this.potrdi.Size = new System.Drawing.Size(75, 30);
            this.potrdi.TabIndex = 10;
            this.potrdi.Text = "Potrdi";
            this.potrdi.UseVisualStyleBackColor = true;
            this.potrdi.Click += new System.EventHandler(this.potrdi_Click);
            // 
            // prikazPodatkov
            // 
            this.prikazPodatkov.AllowUserToOrderColumns = true;
            this.prikazPodatkov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazPodatkov.Location = new System.Drawing.Point(12, 194);
            this.prikazPodatkov.Name = "prikazPodatkov";
            this.prikazPodatkov.Size = new System.Drawing.Size(357, 227);
            this.prikazPodatkov.TabIndex = 12;
            // 
            // prikazPodatkov2
            // 
            this.prikazPodatkov2.AllowUserToOrderColumns = true;
            this.prikazPodatkov2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazPodatkov2.Location = new System.Drawing.Point(388, 194);
            this.prikazPodatkov2.Name = "prikazPodatkov2";
            this.prikazPodatkov2.Size = new System.Drawing.Size(357, 227);
            this.prikazPodatkov2.TabIndex = 13;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(757, 433);
            this.Controls.Add(this.prikazPodatkov2);
            this.Controls.Add(this.prikazPodatkov);
            this.Controls.Add(this.potrdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.novaOcena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idFilma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ocena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Okno";
            this.Text = "Delo z bazo";
            ((System.ComponentModel.ISupportInitialize)(this.prikazPodatkov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPodatkov2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ocena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idFilma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox novaOcena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button potrdi;
        private System.Windows.Forms.DataGridView prikazPodatkov;
        private System.Windows.Forms.DataGridView prikazPodatkov2;
    }
}

