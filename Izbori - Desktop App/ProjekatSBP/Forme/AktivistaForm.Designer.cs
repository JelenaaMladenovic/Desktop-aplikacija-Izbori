namespace ProjekatSBP.Forme
{
    partial class AktivistaForm
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
            this.listViewSveAktiviste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiAktivistu = new System.Windows.Forms.Button();
            this.btnDodajAktivistu = new System.Windows.Forms.Button();
            this.btnIzmeniAktivistu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRasporedi = new System.Windows.Forms.Button();
            this.btnPrimedba = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSveAktiviste
            // 
            this.listViewSveAktiviste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewSveAktiviste.FullRowSelect = true;
            this.listViewSveAktiviste.HideSelection = false;
            this.listViewSveAktiviste.Location = new System.Drawing.Point(6, 21);
            this.listViewSveAktiviste.Name = "listViewSveAktiviste";
            this.listViewSveAktiviste.Size = new System.Drawing.Size(975, 452);
            this.listViewSveAktiviste.TabIndex = 3;
            this.listViewSveAktiviste.UseCompatibleStateImageBehavior = false;
            this.listViewSveAktiviste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime roditelja";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum rodjenja";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adresa";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Broj telefona";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Primedba";
            this.columnHeader9.Width = 79;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Id glasačkog mesta";
            this.columnHeader10.Width = 95;
            // 
            // btnObrisiAktivistu
            // 
            this.btnObrisiAktivistu.BackColor = System.Drawing.Color.White;
            this.btnObrisiAktivistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAktivistu.Location = new System.Drawing.Point(1015, 166);
            this.btnObrisiAktivistu.Name = "btnObrisiAktivistu";
            this.btnObrisiAktivistu.Size = new System.Drawing.Size(123, 48);
            this.btnObrisiAktivistu.TabIndex = 6;
            this.btnObrisiAktivistu.Text = "Obriši aktivistu";
            this.btnObrisiAktivistu.UseVisualStyleBackColor = false;
            this.btnObrisiAktivistu.Click += new System.EventHandler(this.btnObrisiAktivistu_Click);
            // 
            // btnDodajAktivistu
            // 
            this.btnDodajAktivistu.BackColor = System.Drawing.Color.White;
            this.btnDodajAktivistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAktivistu.Location = new System.Drawing.Point(1015, 33);
            this.btnDodajAktivistu.Name = "btnDodajAktivistu";
            this.btnDodajAktivistu.Size = new System.Drawing.Size(123, 50);
            this.btnDodajAktivistu.TabIndex = 7;
            this.btnDodajAktivistu.Text = "Dodaj aktivistu";
            this.btnDodajAktivistu.UseVisualStyleBackColor = false;
            this.btnDodajAktivistu.Click += new System.EventHandler(this.btnDodajAktivistu_Click);
            // 
            // btnIzmeniAktivistu
            // 
            this.btnIzmeniAktivistu.BackColor = System.Drawing.Color.White;
            this.btnIzmeniAktivistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniAktivistu.Location = new System.Drawing.Point(1015, 99);
            this.btnIzmeniAktivistu.Name = "btnIzmeniAktivistu";
            this.btnIzmeniAktivistu.Size = new System.Drawing.Size(123, 48);
            this.btnIzmeniAktivistu.TabIndex = 8;
            this.btnIzmeniAktivistu.Text = "Izmeni aktivistu";
            this.btnIzmeniAktivistu.UseVisualStyleBackColor = false;
            this.btnIzmeniAktivistu.Click += new System.EventHandler(this.btnIzmeniAktivistu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRasporedi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(999, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rsporedi aktivistu na glasačko mesto:";
            // 
            // btnRasporedi
            // 
            this.btnRasporedi.BackColor = System.Drawing.Color.White;
            this.btnRasporedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasporedi.Location = new System.Drawing.Point(18, 85);
            this.btnRasporedi.Name = "btnRasporedi";
            this.btnRasporedi.Size = new System.Drawing.Size(108, 48);
            this.btnRasporedi.TabIndex = 0;
            this.btnRasporedi.Text = "Rasporedi";
            this.btnRasporedi.UseVisualStyleBackColor = false;
            this.btnRasporedi.Click += new System.EventHandler(this.btnRasporedi_Click);
            // 
            // btnPrimedba
            // 
            this.btnPrimedba.BackColor = System.Drawing.Color.White;
            this.btnPrimedba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimedba.Location = new System.Drawing.Point(1017, 252);
            this.btnPrimedba.Name = "btnPrimedba";
            this.btnPrimedba.Size = new System.Drawing.Size(108, 52);
            this.btnPrimedba.TabIndex = 10;
            this.btnPrimedba.Text = "Dodaj primedbu";
            this.btnPrimedba.UseVisualStyleBackColor = false;
            this.btnPrimedba.Click += new System.EventHandler(this.btnPrimedba_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewSveAktiviste);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 479);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista svih aktivista:";
            // 
            // AktivistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1150, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrimedba);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniAktivistu);
            this.Controls.Add(this.btnDodajAktivistu);
            this.Controls.Add(this.btnObrisiAktivistu);
            this.Name = "AktivistaForm";
            this.Text = "Aktivisti";
            this.Load += new System.EventHandler(this.AktivistaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSveAktiviste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnObrisiAktivistu;
        private System.Windows.Forms.Button btnDodajAktivistu;
        private System.Windows.Forms.Button btnIzmeniAktivistu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRasporedi;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnPrimedba;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}