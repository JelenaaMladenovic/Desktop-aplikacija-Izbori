
namespace ProjekatSBP.Forme
{
    partial class ProtivkandidatiForm
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
            this.listViewProtivkandidati = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajProtivkandidata = new System.Windows.Forms.Button();
            this.btnObrisiProtivkandidata = new System.Windows.Forms.Button();
            this.txbProtiv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProtivkandidati
            // 
            this.listViewProtivkandidati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewProtivkandidati.FullRowSelect = true;
            this.listViewProtivkandidati.HideSelection = false;
            this.listViewProtivkandidati.Location = new System.Drawing.Point(10, 21);
            this.listViewProtivkandidati.Name = "listViewProtivkandidati";
            this.listViewProtivkandidati.Size = new System.Drawing.Size(348, 232);
            this.listViewProtivkandidati.TabIndex = 0;
            this.listViewProtivkandidati.UseCompatibleStateImageBehavior = false;
            this.listViewProtivkandidati.View = System.Windows.Forms.View.Details;
            this.listViewProtivkandidati.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRORIVKANDIDATI";
            this.columnHeader1.Width = 500;
            // 
            // btnDodajProtivkandidata
            // 
            this.btnDodajProtivkandidata.BackColor = System.Drawing.Color.White;
            this.btnDodajProtivkandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProtivkandidata.Location = new System.Drawing.Point(38, 92);
            this.btnDodajProtivkandidata.Name = "btnDodajProtivkandidata";
            this.btnDodajProtivkandidata.Size = new System.Drawing.Size(179, 39);
            this.btnDodajProtivkandidata.TabIndex = 1;
            this.btnDodajProtivkandidata.Text = "Dodaj protivkandidata";
            this.btnDodajProtivkandidata.UseVisualStyleBackColor = false;
            this.btnDodajProtivkandidata.Click += new System.EventHandler(this.btnDodajProtivkandidata_Click);
            // 
            // btnObrisiProtivkandidata
            // 
            this.btnObrisiProtivkandidata.BackColor = System.Drawing.Color.White;
            this.btnObrisiProtivkandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiProtivkandidata.Location = new System.Drawing.Point(429, 198);
            this.btnObrisiProtivkandidata.Name = "btnObrisiProtivkandidata";
            this.btnObrisiProtivkandidata.Size = new System.Drawing.Size(179, 35);
            this.btnObrisiProtivkandidata.TabIndex = 2;
            this.btnObrisiProtivkandidata.Text = "Obriši protivkandidata";
            this.btnObrisiProtivkandidata.UseVisualStyleBackColor = false;
            this.btnObrisiProtivkandidata.Click += new System.EventHandler(this.btnObrisiProtivkandidata_Click);
            // 
            // txbProtiv
            // 
            this.txbProtiv.Location = new System.Drawing.Point(6, 52);
            this.txbProtiv.Name = "txbProtiv";
            this.txbProtiv.Size = new System.Drawing.Size(251, 22);
            this.txbProtiv.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewProtivkandidati);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista protivkandidata:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbProtiv);
            this.groupBox2.Controls.Add(this.btnDodajProtivkandidata);
            this.groupBox2.Location = new System.Drawing.Point(391, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 142);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upišite ime i prezime protivkandidata kojeg želite da dodate:";
            // 
            // ProtivkandidatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(675, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiProtivkandidata);
            this.Name = "ProtivkandidatiForm";
            this.Text = "TVDuel";
            this.Load += new System.EventHandler(this.ProtivkandidatiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProtivkandidati;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDodajProtivkandidata;
        private System.Windows.Forms.Button btnObrisiProtivkandidata;
        private System.Windows.Forms.TextBox txbProtiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}