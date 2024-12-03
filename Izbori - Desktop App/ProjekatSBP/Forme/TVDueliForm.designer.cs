
namespace ProjekatSBP.Forme
{
    partial class TVDueliForm
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
            this.listViewTVDueli = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajDuel = new System.Windows.Forms.Button();
            this.btnIzmeniDuel = new System.Windows.Forms.Button();
            this.btnObrisiTVDuel = new System.Windows.Forms.Button();
            this.btnSpisakPitanja = new System.Windows.Forms.Button();
            this.btnProtivkandidati = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTVDueli
            // 
            this.listViewTVDueli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTVDueli.FullRowSelect = true;
            this.listViewTVDueli.HideSelection = false;
            this.listViewTVDueli.Location = new System.Drawing.Point(6, 21);
            this.listViewTVDueli.Name = "listViewTVDueli";
            this.listViewTVDueli.Size = new System.Drawing.Size(600, 324);
            this.listViewTVDueli.TabIndex = 1;
            this.listViewTVDueli.UseCompatibleStateImageBehavior = false;
            this.listViewTVDueli.View = System.Windows.Forms.View.Details;
            this.listViewTVDueli.SelectedIndexChanged += new System.EventHandler(this.listViewTVDueli_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv stanice";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Naziv emisije";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime voditelja";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gledanost";
            this.columnHeader5.Width = 100;
            // 
            // btnDodajDuel
            // 
            this.btnDodajDuel.BackColor = System.Drawing.Color.White;
            this.btnDodajDuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDuel.Location = new System.Drawing.Point(6, 21);
            this.btnDodajDuel.Name = "btnDodajDuel";
            this.btnDodajDuel.Size = new System.Drawing.Size(155, 29);
            this.btnDodajDuel.TabIndex = 2;
            this.btnDodajDuel.Text = "Dodaj TVDuel";
            this.btnDodajDuel.UseVisualStyleBackColor = false;
            this.btnDodajDuel.Click += new System.EventHandler(this.btnDodajDuel_Click);
            // 
            // btnIzmeniDuel
            // 
            this.btnIzmeniDuel.BackColor = System.Drawing.Color.White;
            this.btnIzmeniDuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniDuel.Location = new System.Drawing.Point(6, 56);
            this.btnIzmeniDuel.Name = "btnIzmeniDuel";
            this.btnIzmeniDuel.Size = new System.Drawing.Size(155, 32);
            this.btnIzmeniDuel.TabIndex = 3;
            this.btnIzmeniDuel.Text = "Izmeni TVDuel";
            this.btnIzmeniDuel.UseVisualStyleBackColor = false;
            this.btnIzmeniDuel.Click += new System.EventHandler(this.btnIzmeniDuel_Click);
            // 
            // btnObrisiTVDuel
            // 
            this.btnObrisiTVDuel.BackColor = System.Drawing.Color.White;
            this.btnObrisiTVDuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTVDuel.Location = new System.Drawing.Point(6, 94);
            this.btnObrisiTVDuel.Name = "btnObrisiTVDuel";
            this.btnObrisiTVDuel.Size = new System.Drawing.Size(155, 31);
            this.btnObrisiTVDuel.TabIndex = 4;
            this.btnObrisiTVDuel.Text = "Obriši TVDuel";
            this.btnObrisiTVDuel.UseVisualStyleBackColor = false;
            this.btnObrisiTVDuel.Click += new System.EventHandler(this.btnObrisiTVDuel_Click);
            // 
            // btnSpisakPitanja
            // 
            this.btnSpisakPitanja.BackColor = System.Drawing.Color.White;
            this.btnSpisakPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpisakPitanja.Location = new System.Drawing.Point(6, 53);
            this.btnSpisakPitanja.Name = "btnSpisakPitanja";
            this.btnSpisakPitanja.Size = new System.Drawing.Size(155, 39);
            this.btnSpisakPitanja.TabIndex = 5;
            this.btnSpisakPitanja.Text = "Spisak pitanja";
            this.btnSpisakPitanja.UseVisualStyleBackColor = false;
            this.btnSpisakPitanja.Click += new System.EventHandler(this.btnSpisakPitanja_Click);
            // 
            // btnProtivkandidati
            // 
            this.btnProtivkandidati.BackColor = System.Drawing.Color.White;
            this.btnProtivkandidati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProtivkandidati.Location = new System.Drawing.Point(6, 98);
            this.btnProtivkandidati.Name = "btnProtivkandidati";
            this.btnProtivkandidati.Size = new System.Drawing.Size(155, 39);
            this.btnProtivkandidati.TabIndex = 6;
            this.btnProtivkandidati.Text = "Protivkandidati";
            this.btnProtivkandidati.UseVisualStyleBackColor = false;
            this.btnProtivkandidati.Click += new System.EventHandler(this.btnProtivkandidati_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewTVDueli);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 351);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TVDueli";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajDuel);
            this.groupBox2.Controls.Add(this.btnIzmeniDuel);
            this.groupBox2.Controls.Add(this.btnObrisiTVDuel);
            this.groupBox2.Location = new System.Drawing.Point(630, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSpisakPitanja);
            this.groupBox3.Controls.Add(this.btnProtivkandidati);
            this.groupBox3.Location = new System.Drawing.Point(630, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 143);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodatni podaci o željenom duelu:";
            // 
            // TVDueliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(816, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TVDueliForm";
            this.Text = "TVDueli";
            this.Load += new System.EventHandler(this.TVDueliForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTVDueli;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDodajDuel;
        private System.Windows.Forms.Button btnIzmeniDuel;
        private System.Windows.Forms.Button btnObrisiTVDuel;
        private System.Windows.Forms.Button btnSpisakPitanja;
        private System.Windows.Forms.Button btnProtivkandidati;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}