namespace ProjekatSBP.Forme
{
    partial class KrugoviDodajForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProcenatZa = new System.Windows.Forms.TextBox();
            this.txbBrBiracaIzasli = new System.Windows.Forms.TextBox();
            this.txbBrojKruga = new System.Windows.Forms.TextBox();
            this.button1Dodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Procenat za:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Broj biraca koji su izasli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Broj kruga:";
            // 
            // txbProcenatZa
            // 
            this.txbProcenatZa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProcenatZa.Location = new System.Drawing.Point(218, 142);
            this.txbProcenatZa.Name = "txbProcenatZa";
            this.txbProcenatZa.Size = new System.Drawing.Size(177, 27);
            this.txbProcenatZa.TabIndex = 20;
            // 
            // txbBrBiracaIzasli
            // 
            this.txbBrBiracaIzasli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrBiracaIzasli.Location = new System.Drawing.Point(218, 81);
            this.txbBrBiracaIzasli.Name = "txbBrBiracaIzasli";
            this.txbBrBiracaIzasli.Size = new System.Drawing.Size(177, 27);
            this.txbBrBiracaIzasli.TabIndex = 21;
            // 
            // txbBrojKruga
            // 
            this.txbBrojKruga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrojKruga.Location = new System.Drawing.Point(218, 28);
            this.txbBrojKruga.Name = "txbBrojKruga";
            this.txbBrojKruga.Size = new System.Drawing.Size(177, 27);
            this.txbBrojKruga.TabIndex = 22;
            // 
            // button1Dodaj
            // 
            this.button1Dodaj.BackColor = System.Drawing.Color.White;
            this.button1Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Dodaj.Location = new System.Drawing.Point(320, 206);
            this.button1Dodaj.Name = "button1Dodaj";
            this.button1Dodaj.Size = new System.Drawing.Size(100, 31);
            this.button1Dodaj.TabIndex = 27;
            this.button1Dodaj.Text = "Dodaj";
            this.button1Dodaj.UseVisualStyleBackColor = false;
            this.button1Dodaj.Click += new System.EventHandler(this.button1Dodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbBrojKruga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBrBiracaIzasli);
            this.groupBox1.Controls.Add(this.txbProcenatZa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 188);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o krugu:";
            // 
            // KrugoviDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(431, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1Dodaj);
            this.Name = "KrugoviDodajForm";
            this.Text = "Krug";
            this.Load += new System.EventHandler(this.KrugoviDodajForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProcenatZa;
        private System.Windows.Forms.TextBox txbBrBiracaIzasli;
        private System.Windows.Forms.TextBox txbBrojKruga;
        private System.Windows.Forms.Button button1Dodaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}