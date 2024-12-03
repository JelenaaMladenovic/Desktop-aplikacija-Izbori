
namespace ProjekatSBP.Forme
{
    partial class TVDueliIzmeniForm
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
            this.btnIzmeniDuel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gledanost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ime i prezime voditelja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Naziv emisije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naziv stanice:";
            // 
            // txbGledanost
            // 
            this.txbGledanost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGledanost.Location = new System.Drawing.Point(211, 156);
            this.txbGledanost.Name = "txbGledanost";
            this.txbGledanost.Size = new System.Drawing.Size(152, 26);
            this.txbGledanost.TabIndex = 19;
            // 
            // txbVoditelj
            // 
            this.txbVoditelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVoditelj.Location = new System.Drawing.Point(211, 116);
            this.txbVoditelj.Name = "txbVoditelj";
            this.txbVoditelj.Size = new System.Drawing.Size(152, 26);
            this.txbVoditelj.TabIndex = 18;
            // 
            // txbNazivEmisije
            // 
            this.txbNazivEmisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivEmisije.Location = new System.Drawing.Point(211, 65);
            this.txbNazivEmisije.Name = "txbNazivEmisije";
            this.txbNazivEmisije.Size = new System.Drawing.Size(152, 26);
            this.txbNazivEmisije.TabIndex = 17;
            // 
            // txbNazivstanice
            // 
            this.txbNazivstanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivstanice.Location = new System.Drawing.Point(211, 23);
            this.txbNazivstanice.Name = "txbNazivstanice";
            this.txbNazivstanice.Size = new System.Drawing.Size(152, 26);
            this.txbNazivstanice.TabIndex = 16;
            // 
            // btnIzmeniDuel
            // 
            this.btnIzmeniDuel.BackColor = System.Drawing.Color.White;
            this.btnIzmeniDuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniDuel.Location = new System.Drawing.Point(268, 215);
            this.btnIzmeniDuel.Name = "btnIzmeniDuel";
            this.btnIzmeniDuel.Size = new System.Drawing.Size(100, 34);
            this.btnIzmeniDuel.TabIndex = 24;
            this.btnIzmeniDuel.Text = "Ažuriraj";
            this.btnIzmeniDuel.UseVisualStyleBackColor = false;
            this.btnIzmeniDuel.Click += new System.EventHandler(this.btnIzmeniDuel_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(375, 197);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o TVDuelu:";
            // 
            // TVDueliIzmeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(388, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniDuel);
            this.Name = "TVDueliIzmeniForm";
            this.Text = "TVDuel";
            this.Load += new System.EventHandler(this.TVDueliIzmeniForm_Load);
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
        private System.Windows.Forms.Button btnIzmeniDuel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}