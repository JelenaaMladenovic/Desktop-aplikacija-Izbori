
namespace ProjekatSBP.Forme
{
    partial class MedijiForm
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
            this.btnIntervjuNovine = new System.Windows.Forms.Button();
            this.btnTVIRadioEmisije = new System.Windows.Forms.Button();
            this.btnTVDueli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntervjuNovine
            // 
            this.btnIntervjuNovine.BackColor = System.Drawing.Color.White;
            this.btnIntervjuNovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervjuNovine.Location = new System.Drawing.Point(143, 57);
            this.btnIntervjuNovine.Name = "btnIntervjuNovine";
            this.btnIntervjuNovine.Size = new System.Drawing.Size(167, 52);
            this.btnIntervjuNovine.TabIndex = 0;
            this.btnIntervjuNovine.Text = "Intervjui u novinama";
            this.btnIntervjuNovine.UseVisualStyleBackColor = false;
            this.btnIntervjuNovine.Click += new System.EventHandler(this.btnIntervjuNovine_Click_1);
            // 
            // btnTVIRadioEmisije
            // 
            this.btnTVIRadioEmisije.BackColor = System.Drawing.Color.White;
            this.btnTVIRadioEmisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVIRadioEmisije.Location = new System.Drawing.Point(143, 145);
            this.btnTVIRadioEmisije.Name = "btnTVIRadioEmisije";
            this.btnTVIRadioEmisije.Size = new System.Drawing.Size(167, 43);
            this.btnTVIRadioEmisije.TabIndex = 1;
            this.btnTVIRadioEmisije.Text = "TV i radio emisije";
            this.btnTVIRadioEmisije.UseVisualStyleBackColor = false;
            this.btnTVIRadioEmisije.Click += new System.EventHandler(this.btnTVIRadioEmisije_Click);
            // 
            // btnTVDueli
            // 
            this.btnTVDueli.BackColor = System.Drawing.Color.White;
            this.btnTVDueli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVDueli.Location = new System.Drawing.Point(143, 230);
            this.btnTVDueli.Name = "btnTVDueli";
            this.btnTVDueli.Size = new System.Drawing.Size(167, 38);
            this.btnTVDueli.TabIndex = 2;
            this.btnTVDueli.Text = "TVDueli";
            this.btnTVDueli.UseVisualStyleBackColor = false;
            this.btnTVDueli.Click += new System.EventHandler(this.btnTVDueli_Click);
            // 
            // MedijiForm
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(461, 331);
            this.Controls.Add(this.btnTVDueli);
            this.Controls.Add(this.btnTVIRadioEmisije);
            this.Controls.Add(this.btnIntervjuNovine);
            this.Name = "MedijiForm";
            this.Text = "Mediji";
            this.Load += new System.EventHandler(this.MedijiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntervjuNovine_Click;
        private System.Windows.Forms.Button btnIntervjuNovine;
        private System.Windows.Forms.Button btnTVIRadioEmisije;
        private System.Windows.Forms.Button btnTVDueli;
    }
}