namespace ProjekatSBP.Forme
{
    partial class GlasackoMestoForm
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
            this.listViewSvaGlasackaMesta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiGlasackoMesto = new System.Windows.Forms.Button();
            this.btnDodajGlasackoMesto = new System.Windows.Forms.Button();
            this.btnIzmeniGlasackoMesto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSvaGlasackaMesta
            // 
            this.listViewSvaGlasackaMesta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSvaGlasackaMesta.FullRowSelect = true;
            this.listViewSvaGlasackaMesta.HideSelection = false;
            this.listViewSvaGlasackaMesta.Location = new System.Drawing.Point(6, 24);
            this.listViewSvaGlasackaMesta.Name = "listViewSvaGlasackaMesta";
            this.listViewSvaGlasackaMesta.Size = new System.Drawing.Size(541, 337);
            this.listViewSvaGlasackaMesta.TabIndex = 3;
            this.listViewSvaGlasackaMesta.UseCompatibleStateImageBehavior = false;
            this.listViewSvaGlasackaMesta.View = System.Windows.Forms.View.Details;
            this.listViewSvaGlasackaMesta.SelectedIndexChanged += new System.EventHandler(this.listViewSvaGlasackaMesta_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv izborne jedinice";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj glasackog mesta";
            this.columnHeader3.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj biraca";
            this.columnHeader4.Width = 130;
            // 
            // btnObrisiGlasackoMesto
            // 
            this.btnObrisiGlasackoMesto.BackColor = System.Drawing.Color.White;
            this.btnObrisiGlasackoMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiGlasackoMesto.Location = new System.Drawing.Point(573, 147);
            this.btnObrisiGlasackoMesto.Name = "btnObrisiGlasackoMesto";
            this.btnObrisiGlasackoMesto.Size = new System.Drawing.Size(186, 54);
            this.btnObrisiGlasackoMesto.TabIndex = 6;
            this.btnObrisiGlasackoMesto.Text = "Obriši glasačko mesto";
            this.btnObrisiGlasackoMesto.UseVisualStyleBackColor = false;
            this.btnObrisiGlasackoMesto.Click += new System.EventHandler(this.btnObrisiGlasackoMesto_Click);
            // 
            // btnDodajGlasackoMesto
            // 
            this.btnDodajGlasackoMesto.BackColor = System.Drawing.Color.White;
            this.btnDodajGlasackoMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGlasackoMesto.Location = new System.Drawing.Point(574, 38);
            this.btnDodajGlasackoMesto.Name = "btnDodajGlasackoMesto";
            this.btnDodajGlasackoMesto.Size = new System.Drawing.Size(185, 45);
            this.btnDodajGlasackoMesto.TabIndex = 7;
            this.btnDodajGlasackoMesto.Text = "Dodaj glasačko mesto";
            this.btnDodajGlasackoMesto.UseVisualStyleBackColor = false;
            this.btnDodajGlasackoMesto.Click += new System.EventHandler(this.btnDodajGlasackoMesto_Click);
            // 
            // btnIzmeniGlasackoMesto
            // 
            this.btnIzmeniGlasackoMesto.BackColor = System.Drawing.Color.White;
            this.btnIzmeniGlasackoMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniGlasackoMesto.Location = new System.Drawing.Point(574, 89);
            this.btnIzmeniGlasackoMesto.Name = "btnIzmeniGlasackoMesto";
            this.btnIzmeniGlasackoMesto.Size = new System.Drawing.Size(185, 52);
            this.btnIzmeniGlasackoMesto.TabIndex = 8;
            this.btnIzmeniGlasackoMesto.Text = "Izmeni glasačko mesto";
            this.btnIzmeniGlasackoMesto.UseVisualStyleBackColor = false;
            this.btnIzmeniGlasackoMesto.Click += new System.EventHandler(this.btnIzmeniGlasackoMesto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewSvaGlasackaMesta);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 371);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista glasačkih mesta:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GlasackoMestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(762, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniGlasackoMesto);
            this.Controls.Add(this.btnDodajGlasackoMesto);
            this.Controls.Add(this.btnObrisiGlasackoMesto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GlasackoMestoForm";
            this.Text = "Glasačka mesta";
            this.Load += new System.EventHandler(this.GlasackoMestoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSvaGlasackaMesta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnObrisiGlasackoMesto;
        private System.Windows.Forms.Button btnDodajGlasackoMesto;
        private System.Windows.Forms.Button btnIzmeniGlasackoMesto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}