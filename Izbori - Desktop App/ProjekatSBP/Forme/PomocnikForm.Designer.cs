namespace ProjekatSBP.Forme
{
    partial class PomocnikForm
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
            this.listViewSviPomocnici = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPomocnika = new System.Windows.Forms.Button();
            this.btnIzmeniPomocnika = new System.Windows.Forms.Button();
            this.btnObrisiPomocnika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSviPomocnici
            // 
            this.listViewSviPomocnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSviPomocnici.FullRowSelect = true;
            this.listViewSviPomocnici.HideSelection = false;
            this.listViewSviPomocnici.Location = new System.Drawing.Point(6, 21);
            this.listViewSviPomocnici.Name = "listViewSviPomocnici";
            this.listViewSviPomocnici.Size = new System.Drawing.Size(790, 324);
            this.listViewSviPomocnici.TabIndex = 4;
            this.listViewSviPomocnici.UseCompatibleStateImageBehavior = false;
            this.listViewSviPomocnici.View = System.Windows.Forms.View.Details;
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
            // btnDodajPomocnika
            // 
            this.btnDodajPomocnika.BackColor = System.Drawing.Color.White;
            this.btnDodajPomocnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPomocnika.Location = new System.Drawing.Point(820, 33);
            this.btnDodajPomocnika.Name = "btnDodajPomocnika";
            this.btnDodajPomocnika.Size = new System.Drawing.Size(161, 42);
            this.btnDodajPomocnika.TabIndex = 8;
            this.btnDodajPomocnika.Text = "Dodaj pomoćnika";
            this.btnDodajPomocnika.UseVisualStyleBackColor = false;
            this.btnDodajPomocnika.Click += new System.EventHandler(this.btnDodajPomocnika_Click);
            // 
            // btnIzmeniPomocnika
            // 
            this.btnIzmeniPomocnika.BackColor = System.Drawing.Color.White;
            this.btnIzmeniPomocnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPomocnika.Location = new System.Drawing.Point(820, 81);
            this.btnIzmeniPomocnika.Name = "btnIzmeniPomocnika";
            this.btnIzmeniPomocnika.Size = new System.Drawing.Size(161, 45);
            this.btnIzmeniPomocnika.TabIndex = 9;
            this.btnIzmeniPomocnika.Text = "Izmeni pomoćnika";
            this.btnIzmeniPomocnika.UseVisualStyleBackColor = false;
            this.btnIzmeniPomocnika.Click += new System.EventHandler(this.btnIzmeniPomocnika_Click);
            // 
            // btnObrisiPomocnika
            // 
            this.btnObrisiPomocnika.BackColor = System.Drawing.Color.White;
            this.btnObrisiPomocnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPomocnika.Location = new System.Drawing.Point(820, 132);
            this.btnObrisiPomocnika.Name = "btnObrisiPomocnika";
            this.btnObrisiPomocnika.Size = new System.Drawing.Size(161, 38);
            this.btnObrisiPomocnika.TabIndex = 12;
            this.btnObrisiPomocnika.Text = "Obriši pomoćnika";
            this.btnObrisiPomocnika.UseVisualStyleBackColor = false;
            this.btnObrisiPomocnika.Click += new System.EventHandler(this.btnObrisiPomocnika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewSviPomocnici);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 351);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pomoćnika:";
            // 
            // PomocnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(993, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiPomocnika);
            this.Controls.Add(this.btnIzmeniPomocnika);
            this.Controls.Add(this.btnDodajPomocnika);
            this.Name = "PomocnikForm";
            this.Text = "Pomoćnici";
            this.Load += new System.EventHandler(this.PomocnikForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSviPomocnici;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDodajPomocnika;
        private System.Windows.Forms.Button btnIzmeniPomocnika;
        private System.Windows.Forms.Button btnObrisiPomocnika;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}