namespace ProjekatSBP.Forme
{
    partial class KrugoviForm
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
            this.listViewSviKrugovi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiKrug = new System.Windows.Forms.Button();
            this.btnDodajKrug = new System.Windows.Forms.Button();
            this.btnIzmeniKrug = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSviKrugovi
            // 
            this.listViewSviKrugovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSviKrugovi.FullRowSelect = true;
            this.listViewSviKrugovi.HideSelection = false;
            this.listViewSviKrugovi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewSviKrugovi.Location = new System.Drawing.Point(6, 21);
            this.listViewSviKrugovi.Name = "listViewSviKrugovi";
            this.listViewSviKrugovi.Size = new System.Drawing.Size(448, 268);
            this.listViewSviKrugovi.TabIndex = 3;
            this.listViewSviKrugovi.UseCompatibleStateImageBehavior = false;
            this.listViewSviKrugovi.View = System.Windows.Forms.View.Details;
            this.listViewSviKrugovi.SelectedIndexChanged += new System.EventHandler(this.listViewSviKrugovi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj kruga";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj biraca koji su izasli";
            this.columnHeader3.Width = 167;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Procenat za";
            this.columnHeader4.Width = 130;
            // 
            // btnObrisiKrug
            // 
            this.btnObrisiKrug.BackColor = System.Drawing.Color.White;
            this.btnObrisiKrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKrug.Location = new System.Drawing.Point(478, 137);
            this.btnObrisiKrug.Name = "btnObrisiKrug";
            this.btnObrisiKrug.Size = new System.Drawing.Size(126, 37);
            this.btnObrisiKrug.TabIndex = 6;
            this.btnObrisiKrug.Text = "Obriši krug";
            this.btnObrisiKrug.UseVisualStyleBackColor = false;
            this.btnObrisiKrug.Click += new System.EventHandler(this.btnObrisiKrug_Click);
            // 
            // btnDodajKrug
            // 
            this.btnDodajKrug.BackColor = System.Drawing.Color.White;
            this.btnDodajKrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKrug.Location = new System.Drawing.Point(478, 33);
            this.btnDodajKrug.Name = "btnDodajKrug";
            this.btnDodajKrug.Size = new System.Drawing.Size(126, 42);
            this.btnDodajKrug.TabIndex = 7;
            this.btnDodajKrug.Text = "Dodaj krug";
            this.btnDodajKrug.UseVisualStyleBackColor = false;
            this.btnDodajKrug.Click += new System.EventHandler(this.btnDodajKrug_Click);
            // 
            // btnIzmeniKrug
            // 
            this.btnIzmeniKrug.BackColor = System.Drawing.Color.White;
            this.btnIzmeniKrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKrug.Location = new System.Drawing.Point(478, 86);
            this.btnIzmeniKrug.Name = "btnIzmeniKrug";
            this.btnIzmeniKrug.Size = new System.Drawing.Size(126, 45);
            this.btnIzmeniKrug.TabIndex = 8;
            this.btnIzmeniKrug.Text = "Izmeni krug";
            this.btnIzmeniKrug.UseVisualStyleBackColor = false;
            this.btnIzmeniKrug.Click += new System.EventHandler(this.btnIzmeniKrug_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewSviKrugovi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 295);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista rezultata:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // KrugoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(619, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniKrug);
            this.Controls.Add(this.btnDodajKrug);
            this.Controls.Add(this.btnObrisiKrug);
            this.Name = "KrugoviForm";
            this.Text = "Krugovi";
            this.Load += new System.EventHandler(this.KrugoviForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSviKrugovi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnObrisiKrug;
        private System.Windows.Forms.Button btnDodajKrug;
        private System.Windows.Forms.Button btnIzmeniKrug;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}