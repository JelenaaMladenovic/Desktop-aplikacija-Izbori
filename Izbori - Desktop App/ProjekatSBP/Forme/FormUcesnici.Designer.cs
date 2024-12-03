namespace ProjekatSBP.Forme
{
    partial class FormUcesnici
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
            this.btnKoordinatori = new System.Windows.Forms.Button();
            this.btnAktivisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKoordinatori
            // 
            this.btnKoordinatori.BackColor = System.Drawing.Color.White;
            this.btnKoordinatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKoordinatori.Location = new System.Drawing.Point(71, 103);
            this.btnKoordinatori.Name = "btnKoordinatori";
            this.btnKoordinatori.Size = new System.Drawing.Size(168, 56);
            this.btnKoordinatori.TabIndex = 1;
            this.btnKoordinatori.Text = "Koordinatori";
            this.btnKoordinatori.UseVisualStyleBackColor = false;
            this.btnKoordinatori.Click += new System.EventHandler(this.btnKoordinatori_Click);
            // 
            // btnAktivisti
            // 
            this.btnAktivisti.BackColor = System.Drawing.Color.White;
            this.btnAktivisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktivisti.Location = new System.Drawing.Point(71, 199);
            this.btnAktivisti.Name = "btnAktivisti";
            this.btnAktivisti.Size = new System.Drawing.Size(168, 56);
            this.btnAktivisti.TabIndex = 3;
            this.btnAktivisti.Text = "Aktivisti";
            this.btnAktivisti.UseVisualStyleBackColor = false;
            this.btnAktivisti.Click += new System.EventHandler(this.btnAktivisti_Click);
            // 
            // FormUcesnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(333, 367);
            this.Controls.Add(this.btnAktivisti);
            this.Controls.Add(this.btnKoordinatori);
            this.Name = "FormUcesnici";
            this.Text = "Učesnici";
            this.Load += new System.EventHandler(this.FormUcesnici_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKoordinatori;
        private System.Windows.Forms.Button btnAktivisti;
    }
}