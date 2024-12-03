
namespace ProjekatSBP.Forme
{
    partial class PromoForm
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
            this.btnAkcija = new System.Windows.Forms.Button();
            this.btnReklame = new System.Windows.Forms.Button();
            this.btnGosti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkcija
            // 
            this.btnAkcija.BackColor = System.Drawing.Color.White;
            this.btnAkcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkcija.Location = new System.Drawing.Point(110, 120);
            this.btnAkcija.Name = "btnAkcija";
            this.btnAkcija.Size = new System.Drawing.Size(96, 40);
            this.btnAkcija.TabIndex = 0;
            this.btnAkcija.Text = "Akcije";
            this.btnAkcija.UseVisualStyleBackColor = false;
            this.btnAkcija.Click += new System.EventHandler(this.btnAkcija_Click);
            // 
            // btnReklame
            // 
            this.btnReklame.BackColor = System.Drawing.Color.White;
            this.btnReklame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReklame.Location = new System.Drawing.Point(110, 206);
            this.btnReklame.Name = "btnReklame";
            this.btnReklame.Size = new System.Drawing.Size(96, 41);
            this.btnReklame.TabIndex = 1;
            this.btnReklame.Text = "Reklame";
            this.btnReklame.UseVisualStyleBackColor = false;
            this.btnReklame.Click += new System.EventHandler(this.btnReklame_Click);
            // 
            // btnGosti
            // 
            this.btnGosti.BackColor = System.Drawing.Color.White;
            this.btnGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGosti.Location = new System.Drawing.Point(110, 291);
            this.btnGosti.Name = "btnGosti";
            this.btnGosti.Size = new System.Drawing.Size(96, 35);
            this.btnGosti.TabIndex = 2;
            this.btnGosti.Text = "Gosti";
            this.btnGosti.UseVisualStyleBackColor = false;
            this.btnGosti.Click += new System.EventHandler(this.btnGosti_Click);
            // 
            // PromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.btnGosti);
            this.Controls.Add(this.btnReklame);
            this.Controls.Add(this.btnAkcija);
            this.Name = "PromoForm";
            this.Text = "Promovisanje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAkcija;
        private System.Windows.Forms.Button btnReklame;
        private System.Windows.Forms.Button btnGosti;
    }
}