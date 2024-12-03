namespace ProjekatSBP.Forme
{
    partial class KoordinatorForm
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
            this.listViewSviKoordinatori = new System.Windows.Forms.ListView();
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
            this.btnDodajKoordinatora = new System.Windows.Forms.Button();
            this.btnIzmeniKoordinatora = new System.Windows.Forms.Button();
            this.btnObrisiKoordinatora = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSviKoordinatori
            // 
            this.listViewSviKoordinatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listViewSviKoordinatori.FullRowSelect = true;
            this.listViewSviKoordinatori.HideSelection = false;
            this.listViewSviKoordinatori.Location = new System.Drawing.Point(6, 21);
            this.listViewSviKoordinatori.Name = "listViewSviKoordinatori";
            this.listViewSviKoordinatori.Size = new System.Drawing.Size(1018, 365);
            this.listViewSviKoordinatori.TabIndex = 3;
            this.listViewSviKoordinatori.UseCompatibleStateImageBehavior = false;
            this.listViewSviKoordinatori.View = System.Windows.Forms.View.Details;
            this.listViewSviKoordinatori.SelectedIndexChanged += new System.EventHandler(this.listViewSviKoordinatori_SelectedIndexChanged);
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
            this.columnHeader4.Width = 121;
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
            this.columnHeader8.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ime opštine";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Adresa kancelarije";
            this.columnHeader10.Width = 132;
            // 
            // btnDodajKoordinatora
            // 
            this.btnDodajKoordinatora.BackColor = System.Drawing.Color.White;
            this.btnDodajKoordinatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKoordinatora.Location = new System.Drawing.Point(1048, 33);
            this.btnDodajKoordinatora.Name = "btnDodajKoordinatora";
            this.btnDodajKoordinatora.Size = new System.Drawing.Size(189, 40);
            this.btnDodajKoordinatora.TabIndex = 7;
            this.btnDodajKoordinatora.Text = "Dodaj koordinatora";
            this.btnDodajKoordinatora.UseVisualStyleBackColor = false;
            this.btnDodajKoordinatora.Click += new System.EventHandler(this.btnDodajKoordinatora_Click);
            // 
            // btnIzmeniKoordinatora
            // 
            this.btnIzmeniKoordinatora.BackColor = System.Drawing.Color.White;
            this.btnIzmeniKoordinatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKoordinatora.Location = new System.Drawing.Point(1048, 79);
            this.btnIzmeniKoordinatora.Name = "btnIzmeniKoordinatora";
            this.btnIzmeniKoordinatora.Size = new System.Drawing.Size(189, 45);
            this.btnIzmeniKoordinatora.TabIndex = 8;
            this.btnIzmeniKoordinatora.Text = "Izmeni koordinatora";
            this.btnIzmeniKoordinatora.UseVisualStyleBackColor = false;
            this.btnIzmeniKoordinatora.Click += new System.EventHandler(this.btnIzmeniKoordinatora_Click);
            // 
            // btnObrisiKoordinatora
            // 
            this.btnObrisiKoordinatora.BackColor = System.Drawing.Color.White;
            this.btnObrisiKoordinatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKoordinatora.Location = new System.Drawing.Point(1048, 130);
            this.btnObrisiKoordinatora.Name = "btnObrisiKoordinatora";
            this.btnObrisiKoordinatora.Size = new System.Drawing.Size(189, 44);
            this.btnObrisiKoordinatora.TabIndex = 11;
            this.btnObrisiKoordinatora.Text = "Obriši koordinatora";
            this.btnObrisiKoordinatora.UseVisualStyleBackColor = false;
            this.btnObrisiKoordinatora.Click += new System.EventHandler(this.btnObrisiKoordinatora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1048, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o pomoćnicima izabranog koordinatora";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pomoćnici";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewSviKoordinatori);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 392);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista koordinatora:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // KoordinatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1249, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiKoordinatora);
            this.Controls.Add(this.btnIzmeniKoordinatora);
            this.Controls.Add(this.btnDodajKoordinatora);
            this.Name = "KoordinatorForm";
            this.Text = "Koordinatori";
            this.Load += new System.EventHandler(this.KoordinatorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSviKoordinatori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDodajKoordinatora;
        private System.Windows.Forms.Button btnIzmeniKoordinatora;
        private System.Windows.Forms.Button btnObrisiKoordinatora;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}