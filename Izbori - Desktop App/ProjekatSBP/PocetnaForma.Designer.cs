
namespace ProjekatSBP
{
    partial class PocetnaForma
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
            this.btnUcesnici = new System.Windows.Forms.Button();
            this.btnGlasackaMesta = new System.Windows.Forms.Button();
            this.btnKrugovi = new System.Windows.Forms.Button();
            this.btnAkcije = new System.Windows.Forms.Button();
            this.btnMediji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcesnici
            // 
            this.btnUcesnici.BackColor = System.Drawing.Color.White;
            this.btnUcesnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcesnici.Location = new System.Drawing.Point(154, 64);
            this.btnUcesnici.Name = "btnUcesnici";
            this.btnUcesnici.Size = new System.Drawing.Size(146, 48);
            this.btnUcesnici.TabIndex = 0;
            this.btnUcesnici.Text = "Učesnici";
            this.btnUcesnici.UseVisualStyleBackColor = false;
            this.btnUcesnici.Click += new System.EventHandler(this.btnUcesnici_Click);
            // 
            // btnGlasackaMesta
            // 
            this.btnGlasackaMesta.BackColor = System.Drawing.Color.White;
            this.btnGlasackaMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlasackaMesta.Location = new System.Drawing.Point(154, 134);
            this.btnGlasackaMesta.Name = "btnGlasackaMesta";
            this.btnGlasackaMesta.Size = new System.Drawing.Size(146, 59);
            this.btnGlasackaMesta.TabIndex = 1;
            this.btnGlasackaMesta.Text = "Glasačka mesta";
            this.btnGlasackaMesta.UseVisualStyleBackColor = false;
            this.btnGlasackaMesta.Click += new System.EventHandler(this.btnGlasackaMesta_Click);
            // 
            // btnKrugovi
            // 
            this.btnKrugovi.BackColor = System.Drawing.Color.White;
            this.btnKrugovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKrugovi.Location = new System.Drawing.Point(154, 220);
            this.btnKrugovi.Name = "btnKrugovi";
            this.btnKrugovi.Size = new System.Drawing.Size(146, 50);
            this.btnKrugovi.TabIndex = 2;
            this.btnKrugovi.Text = "Rezultati";
            this.btnKrugovi.UseVisualStyleBackColor = false;
            this.btnKrugovi.Click += new System.EventHandler(this.btnKrugovi_Click);
            // 
            // btnAkcije
            // 
            this.btnAkcije.BackColor = System.Drawing.Color.White;
            this.btnAkcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkcije.ForeColor = System.Drawing.Color.Black;
            this.btnAkcije.Location = new System.Drawing.Point(154, 304);
            this.btnAkcije.Name = "btnAkcije";
            this.btnAkcije.Size = new System.Drawing.Size(146, 54);
            this.btnAkcije.TabIndex = 3;
            this.btnAkcije.Text = "Promovisanje";
            this.btnAkcije.UseVisualStyleBackColor = false;
            this.btnAkcije.Click += new System.EventHandler(this.btnAkcije_Click);
            // 
            // btnMediji
            // 
            this.btnMediji.BackColor = System.Drawing.Color.White;
            this.btnMediji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediji.Location = new System.Drawing.Point(154, 395);
            this.btnMediji.Name = "btnMediji";
            this.btnMediji.Size = new System.Drawing.Size(146, 49);
            this.btnMediji.TabIndex = 4;
            this.btnMediji.Text = "Mediji";
            this.btnMediji.UseVisualStyleBackColor = false;
            this.btnMediji.Click += new System.EventHandler(this.btnMediji_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(444, 519);
            this.Controls.Add(this.btnMediji);
            this.Controls.Add(this.btnAkcije);
            this.Controls.Add(this.btnKrugovi);
            this.Controls.Add(this.btnGlasackaMesta);
            this.Controls.Add(this.btnUcesnici);
            this.Name = "PocetnaForma";
            this.Text = "IZBORI";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcesnici;
        private System.Windows.Forms.Button btnGlasackaMesta;
        private System.Windows.Forms.Button btnKrugovi;
        private System.Windows.Forms.Button btnAkcije;
        private System.Windows.Forms.Button btnMediji;
    }
}