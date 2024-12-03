
namespace ProjekatSBP.Forme
{
    partial class TVIRadioEmisijeForm
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
            this.listViewEmisije = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajEmisiju = new System.Windows.Forms.Button();
            this.btnIzmeniEmisiju = new System.Windows.Forms.Button();
            this.btnObrisiEmisiju = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEmisije
            // 
            this.listViewEmisije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEmisije.FullRowSelect = true;
            this.listViewEmisije.HideSelection = false;
            this.listViewEmisije.Location = new System.Drawing.Point(6, 21);
            this.listViewEmisije.Name = "listViewEmisije";
            this.listViewEmisije.Size = new System.Drawing.Size(537, 303);
            this.listViewEmisije.TabIndex = 0;
            this.listViewEmisije.UseCompatibleStateImageBehavior = false;
            this.listViewEmisije.View = System.Windows.Forms.View.Details;
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
            // btnDodajEmisiju
            // 
            this.btnDodajEmisiju.BackColor = System.Drawing.Color.White;
            this.btnDodajEmisiju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajEmisiju.Location = new System.Drawing.Point(569, 33);
            this.btnDodajEmisiju.Name = "btnDodajEmisiju";
            this.btnDodajEmisiju.Size = new System.Drawing.Size(124, 44);
            this.btnDodajEmisiju.TabIndex = 1;
            this.btnDodajEmisiju.Text = "Dodaj emisiju";
            this.btnDodajEmisiju.UseVisualStyleBackColor = false;
            this.btnDodajEmisiju.Click += new System.EventHandler(this.btnDodajEmisiju_Click);
            // 
            // btnIzmeniEmisiju
            // 
            this.btnIzmeniEmisiju.BackColor = System.Drawing.Color.White;
            this.btnIzmeniEmisiju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniEmisiju.Location = new System.Drawing.Point(569, 83);
            this.btnIzmeniEmisiju.Name = "btnIzmeniEmisiju";
            this.btnIzmeniEmisiju.Size = new System.Drawing.Size(124, 38);
            this.btnIzmeniEmisiju.TabIndex = 2;
            this.btnIzmeniEmisiju.Text = "Izmeni emisiju";
            this.btnIzmeniEmisiju.UseVisualStyleBackColor = false;
            this.btnIzmeniEmisiju.Click += new System.EventHandler(this.btnIzmeniEmisiju_Click);
            // 
            // btnObrisiEmisiju
            // 
            this.btnObrisiEmisiju.BackColor = System.Drawing.Color.White;
            this.btnObrisiEmisiju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiEmisiju.Location = new System.Drawing.Point(569, 127);
            this.btnObrisiEmisiju.Name = "btnObrisiEmisiju";
            this.btnObrisiEmisiju.Size = new System.Drawing.Size(124, 36);
            this.btnObrisiEmisiju.TabIndex = 3;
            this.btnObrisiEmisiju.Text = "Obriši emisiju";
            this.btnObrisiEmisiju.UseVisualStyleBackColor = false;
            this.btnObrisiEmisiju.Click += new System.EventHandler(this.btnObrisiEmisiju_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewEmisije);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 335);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista emisija:";
            // 
            // TVIRadioEmisijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiEmisiju);
            this.Controls.Add(this.btnIzmeniEmisiju);
            this.Controls.Add(this.btnDodajEmisiju);
            this.Name = "TVIRadioEmisijeForm";
            this.Text = "Emisije";
            this.Load += new System.EventHandler(this.TVIRadioEmisijeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmisije;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDodajEmisiju;
        private System.Windows.Forms.Button btnIzmeniEmisiju;
        private System.Windows.Forms.Button btnObrisiEmisiju;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}