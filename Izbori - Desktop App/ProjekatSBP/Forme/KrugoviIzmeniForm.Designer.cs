namespace ProjekatSBP.Forme
{
    partial class KrugoviIzmeniForm
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
            this.txbBrKruga = new System.Windows.Forms.TextBox();
            this.txbProcenatZa = new System.Windows.Forms.TextBox();
            this.txbBrBiracaIzasli = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj kruga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj biraca koji su izasli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProcenatZa:";
            // 
            // txbBrKruga
            // 
            this.txbBrKruga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrKruga.Location = new System.Drawing.Point(202, 28);
            this.txbBrKruga.Name = "txbBrKruga";
            this.txbBrKruga.Size = new System.Drawing.Size(135, 26);
            this.txbBrKruga.TabIndex = 12;
            // 
            // txbProcenatZa
            // 
            this.txbProcenatZa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProcenatZa.Location = new System.Drawing.Point(202, 124);
            this.txbProcenatZa.Name = "txbProcenatZa";
            this.txbProcenatZa.Size = new System.Drawing.Size(135, 26);
            this.txbProcenatZa.TabIndex = 13;
            // 
            // txbBrBiracaIzasli
            // 
            this.txbBrBiracaIzasli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrBiracaIzasli.Location = new System.Drawing.Point(202, 78);
            this.txbBrBiracaIzasli.Name = "txbBrBiracaIzasli";
            this.txbBrBiracaIzasli.Size = new System.Drawing.Size(135, 26);
            this.txbBrBiracaIzasli.TabIndex = 14;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.White;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(244, 197);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(110, 32);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbBrKruga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbBrBiracaIzasli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbProcenatZa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 179);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o krugu:";
            // 
            // KrugoviIzmeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(366, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "KrugoviIzmeniForm";
            this.Text = "Krug";
            this.Load += new System.EventHandler(this.KrugoviIzmeniForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrKruga;
        private System.Windows.Forms.TextBox txbProcenatZa;
        private System.Windows.Forms.TextBox txbBrBiracaIzasli;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}