
namespace ProjekatSBP.Forme
{
    partial class IntervjuNovineForm
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
            this.btnDodajIntervju = new System.Windows.Forms.Button();
            this.listViewSviIntervjui = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiIntervju = new System.Windows.Forms.Button();
            this.btnIzmeniIntervjuNovine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajIntervju
            // 
            this.btnDodajIntervju.BackColor = System.Drawing.Color.White;
            this.btnDodajIntervju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIntervju.Location = new System.Drawing.Point(737, 33);
            this.btnDodajIntervju.Name = "btnDodajIntervju";
            this.btnDodajIntervju.Size = new System.Drawing.Size(129, 47);
            this.btnDodajIntervju.TabIndex = 0;
            this.btnDodajIntervju.Text = "Dodaj Intervju";
            this.btnDodajIntervju.UseVisualStyleBackColor = false;
            this.btnDodajIntervju.Click += new System.EventHandler(this.btnDodajIntervju_Click);
            // 
            // listViewSviIntervjui
            // 
            this.listViewSviIntervjui.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewSviIntervjui.FullRowSelect = true;
            this.listViewSviIntervjui.HideSelection = false;
            this.listViewSviIntervjui.Location = new System.Drawing.Point(6, 21);
            this.listViewSviIntervjui.Name = "listViewSviIntervjui";
            this.listViewSviIntervjui.Size = new System.Drawing.Size(707, 371);
            this.listViewSviIntervjui.TabIndex = 1;
            this.listViewSviIntervjui.UseCompatibleStateImageBehavior = false;
            this.listViewSviIntervjui.View = System.Windows.Forms.View.Details;
            this.listViewSviIntervjui.SelectedIndexChanged += new System.EventHandler(this.listViewSviIntervjui_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv lista";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum pisanja";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum Objavljivanja";
            this.columnHeader4.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Novinar1";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Novinar2";
            this.columnHeader6.Width = 120;
            // 
            // btnObrisiIntervju
            // 
            this.btnObrisiIntervju.BackColor = System.Drawing.Color.White;
            this.btnObrisiIntervju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiIntervju.Location = new System.Drawing.Point(737, 150);
            this.btnObrisiIntervju.Name = "btnObrisiIntervju";
            this.btnObrisiIntervju.Size = new System.Drawing.Size(129, 50);
            this.btnObrisiIntervju.TabIndex = 2;
            this.btnObrisiIntervju.Text = "Obriši intervju";
            this.btnObrisiIntervju.UseVisualStyleBackColor = false;
            this.btnObrisiIntervju.Click += new System.EventHandler(this.btnObrisiIntervju_Click);
            // 
            // btnIzmeniIntervjuNovine
            // 
            this.btnIzmeniIntervjuNovine.BackColor = System.Drawing.Color.White;
            this.btnIzmeniIntervjuNovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniIntervjuNovine.Location = new System.Drawing.Point(737, 86);
            this.btnIzmeniIntervjuNovine.Name = "btnIzmeniIntervjuNovine";
            this.btnIzmeniIntervjuNovine.Size = new System.Drawing.Size(129, 49);
            this.btnIzmeniIntervjuNovine.TabIndex = 5;
            this.btnIzmeniIntervjuNovine.Text = "Izmeni intervju";
            this.btnIzmeniIntervjuNovine.UseVisualStyleBackColor = false;
            this.btnIzmeniIntervjuNovine.Click += new System.EventHandler(this.btnIzmeniIntervjuNovine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewSviIntervjui);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista intervjua:";
            // 
            // IntervjuNovineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniIntervjuNovine);
            this.Controls.Add(this.btnObrisiIntervju);
            this.Controls.Add(this.btnDodajIntervju);
            this.Name = "IntervjuNovineForm";
            this.Text = "Intervju";
            this.Load += new System.EventHandler(this.IntervjuNovineForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajIntervju;
        private System.Windows.Forms.ListView listViewSviIntervjui;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnObrisiIntervju;
        private System.Windows.Forms.Button btnIzmeniIntervjuNovine;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}