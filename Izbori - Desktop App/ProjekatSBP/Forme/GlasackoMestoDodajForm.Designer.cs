namespace ProjekatSBP.Forme
{
    partial class GlasackoMestoDodajForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBrBiraca = new System.Windows.Forms.TextBox();
            this.txbBrGlasackogMesta = new System.Windows.Forms.TextBox();
            this.txbNazivIzborneJedinice = new System.Windows.Forms.TextBox();
            this.button1Dodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj glasackog mesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv izborne jedinice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Broj biraca:";
            // 
            // txbBrBiraca
            // 
            this.txbBrBiraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrBiraca.Location = new System.Drawing.Point(242, 135);
            this.txbBrBiraca.Name = "txbBrBiraca";
            this.txbBrBiraca.Size = new System.Drawing.Size(177, 27);
            this.txbBrBiraca.TabIndex = 20;
            // 
            // txbBrGlasackogMesta
            // 
            this.txbBrGlasackogMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrGlasackogMesta.Location = new System.Drawing.Point(242, 85);
            this.txbBrGlasackogMesta.Name = "txbBrGlasackogMesta";
            this.txbBrGlasackogMesta.Size = new System.Drawing.Size(177, 27);
            this.txbBrGlasackogMesta.TabIndex = 21;
            // 
            // txbNazivIzborneJedinice
            // 
            this.txbNazivIzborneJedinice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivIzborneJedinice.Location = new System.Drawing.Point(242, 37);
            this.txbNazivIzborneJedinice.Name = "txbNazivIzborneJedinice";
            this.txbNazivIzborneJedinice.Size = new System.Drawing.Size(177, 27);
            this.txbNazivIzborneJedinice.TabIndex = 22;
            // 
            // button1Dodaj
            // 
            this.button1Dodaj.BackColor = System.Drawing.Color.White;
            this.button1Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Dodaj.Location = new System.Drawing.Point(317, 228);
            this.button1Dodaj.Name = "button1Dodaj";
            this.button1Dodaj.Size = new System.Drawing.Size(100, 35);
            this.button1Dodaj.TabIndex = 27;
            this.button1Dodaj.Text = "Dodaj";
            this.button1Dodaj.UseVisualStyleBackColor = false;
            this.button1Dodaj.Click += new System.EventHandler(this.button1Dodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbNazivIzborneJedinice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBrGlasackogMesta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbBrBiraca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 200);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o glasačkom mestu:";
            // 
            // GlasackoMestoDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(450, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1Dodaj);
            this.Name = "GlasackoMestoDodajForm";
            this.Text = "Glasačko mesto";
            this.Load += new System.EventHandler(this.GlasackoMestoDodajForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBrBiraca;
        private System.Windows.Forms.TextBox txbBrGlasackogMesta;
        private System.Windows.Forms.TextBox txbNazivIzborneJedinice;
        private System.Windows.Forms.Button button1Dodaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}