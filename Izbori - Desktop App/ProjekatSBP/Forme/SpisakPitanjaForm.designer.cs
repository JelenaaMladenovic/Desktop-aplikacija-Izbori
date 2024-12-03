
namespace ProjekatSBP.Forme
{
    partial class SpisakPitanjaForm
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
            this.listViewPitanja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPitanje = new System.Windows.Forms.Button();
            this.txbDodajPitanje = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPitanja
            // 
            this.listViewPitanja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewPitanja.FullRowSelect = true;
            this.listViewPitanja.HideSelection = false;
            this.listViewPitanja.Location = new System.Drawing.Point(6, 21);
            this.listViewPitanja.Name = "listViewPitanja";
            this.listViewPitanja.Size = new System.Drawing.Size(336, 197);
            this.listViewPitanja.TabIndex = 0;
            this.listViewPitanja.UseCompatibleStateImageBehavior = false;
            this.listViewPitanja.View = System.Windows.Forms.View.Details;
            this.listViewPitanja.SelectedIndexChanged += new System.EventHandler(this.listViewPitanja_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PITANJA";
            this.columnHeader1.Width = 500;
            // 
            // btnDodajPitanje
            // 
            this.btnDodajPitanje.BackColor = System.Drawing.Color.White;
            this.btnDodajPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPitanje.Location = new System.Drawing.Point(76, 81);
            this.btnDodajPitanje.Name = "btnDodajPitanje";
            this.btnDodajPitanje.Size = new System.Drawing.Size(112, 36);
            this.btnDodajPitanje.TabIndex = 1;
            this.btnDodajPitanje.Text = "Dodaj pitanje";
            this.btnDodajPitanje.UseVisualStyleBackColor = false;
            this.btnDodajPitanje.Click += new System.EventHandler(this.btnDodajPitanje_Click);
            // 
            // txbDodajPitanje
            // 
            this.txbDodajPitanje.Location = new System.Drawing.Point(6, 42);
            this.txbDodajPitanje.Name = "txbDodajPitanje";
            this.txbDodajPitanje.Size = new System.Drawing.Size(240, 22);
            this.txbDodajPitanje.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.White;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(452, 182);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(112, 31);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši pitanje";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewPitanja);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pitanja:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDodajPitanje);
            this.groupBox2.Controls.Add(this.btnDodajPitanje);
            this.groupBox2.Location = new System.Drawing.Point(376, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upišite pitanje koje želite da dodate:";
            // 
            // SpisakPitanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(643, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisi);
            this.Name = "SpisakPitanjaForm";
            this.Text = "TVDuel";
            this.Load += new System.EventHandler(this.SpisakPitanjaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPitanja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDodajPitanje;
        private System.Windows.Forms.TextBox txbDodajPitanje;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}