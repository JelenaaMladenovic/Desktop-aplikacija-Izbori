
namespace ProjekatSBP.Forme
{
    partial class TVIRadioEmisijeIzmeniForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbGledanost = new System.Windows.Forms.TextBox();
            this.txbVoditelj = new System.Windows.Forms.TextBox();
            this.txbNazivEmisije = new System.Windows.Forms.TextBox();
            this.txbNazivstanice = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gledanost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ime i prezime voditelja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv emisije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv stanice:";
            // 
            // txbGledanost
            // 
            this.txbGledanost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGledanost.Location = new System.Drawing.Point(204, 154);
            this.txbGledanost.Name = "txbGledanost";
            this.txbGledanost.Size = new System.Drawing.Size(145, 26);
            this.txbGledanost.TabIndex = 11;
            // 
            // txbVoditelj
            // 
            this.txbVoditelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVoditelj.Location = new System.Drawing.Point(204, 100);
            this.txbVoditelj.Name = "txbVoditelj";
            this.txbVoditelj.Size = new System.Drawing.Size(145, 26);
            this.txbVoditelj.TabIndex = 10;
            // 
            // txbNazivEmisije
            // 
            this.txbNazivEmisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivEmisije.Location = new System.Drawing.Point(204, 56);
            this.txbNazivEmisije.Name = "txbNazivEmisije";
            this.txbNazivEmisije.Size = new System.Drawing.Size(145, 26);
            this.txbNazivEmisije.TabIndex = 9;
            // 
            // txbNazivstanice
            // 
            this.txbNazivstanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivstanice.Location = new System.Drawing.Point(204, 18);
            this.txbNazivstanice.Name = "txbNazivstanice";
            this.txbNazivstanice.Size = new System.Drawing.Size(145, 26);
            this.txbNazivstanice.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.White;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(260, 213);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(107, 42);
            this.btnAzuriraj.TabIndex = 16;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNazivstanice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbNazivEmisije);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbVoditelj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbGledanost);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 195);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o emisiji:";
            // 
            // TVIRadioEmisijeIzmeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(380, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "TVIRadioEmisijeIzmeniForm";
            this.Text = "Emisija";
            this.Load += new System.EventHandler(this.TVIRadioEmisijeIzmeniForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGledanost;
        private System.Windows.Forms.TextBox txbVoditelj;
        private System.Windows.Forms.TextBox txbNazivEmisije;
        private System.Windows.Forms.TextBox txbNazivstanice;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}