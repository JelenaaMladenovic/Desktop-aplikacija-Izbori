namespace ProjekatSBP.Forme
{
    partial class GlasackoMestoIzmeniForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBrBiraca = new System.Windows.Forms.TextBox();
            this.txbBrGlasackogMesta = new System.Windows.Forms.TextBox();
            this.txbNazivIzborneJedinice = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv izborne jedinice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj glasackog mesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj biraca:";
            // 
            // txbBrBiraca
            // 
            this.txbBrBiraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrBiraca.Location = new System.Drawing.Point(219, 153);
            this.txbBrBiraca.Name = "txbBrBiraca";
            this.txbBrBiraca.Size = new System.Drawing.Size(158, 26);
            this.txbBrBiraca.TabIndex = 12;
            // 
            // txbBrGlasackogMesta
            // 
            this.txbBrGlasackogMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrGlasackogMesta.Location = new System.Drawing.Point(216, 98);
            this.txbBrGlasackogMesta.Name = "txbBrGlasackogMesta";
            this.txbBrGlasackogMesta.Size = new System.Drawing.Size(158, 26);
            this.txbBrGlasackogMesta.TabIndex = 13;
            // 
            // txbNazivIzborneJedinice
            // 
            this.txbNazivIzborneJedinice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivIzborneJedinice.Location = new System.Drawing.Point(216, 43);
            this.txbNazivIzborneJedinice.Name = "txbNazivIzborneJedinice";
            this.txbNazivIzborneJedinice.Size = new System.Drawing.Size(158, 26);
            this.txbNazivIzborneJedinice.TabIndex = 14;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.White;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(282, 227);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(114, 36);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbNazivIzborneJedinice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbBrGlasackogMesta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBrBiraca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 209);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o glasačkom mestu:";
            // 
            // GlasackoMestoIzmeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(401, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "GlasackoMestoIzmeniForm";
            this.Text = "Glasačko mesto";
            this.Load += new System.EventHandler(this.GlasackoMestoIzmeniForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrBiraca;
        private System.Windows.Forms.TextBox txbBrGlasackogMesta;
        private System.Windows.Forms.TextBox txbNazivIzborneJedinice;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}