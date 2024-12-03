namespace ProjekatSBP.Forme
{
    partial class ReklameForm
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
            this.btnDodajReklamu = new System.Windows.Forms.Button();
            this.Reklame = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiReklamu = new System.Windows.Forms.Button();
            this.btnIzmeniReklamu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajReklamu
            // 
            this.btnDodajReklamu.BackColor = System.Drawing.Color.White;
            this.btnDodajReklamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajReklamu.Location = new System.Drawing.Point(23, 23);
            this.btnDodajReklamu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajReklamu.Name = "btnDodajReklamu";
            this.btnDodajReklamu.Size = new System.Drawing.Size(212, 28);
            this.btnDodajReklamu.TabIndex = 0;
            this.btnDodajReklamu.Text = "Dodaj reklamu";
            this.btnDodajReklamu.UseVisualStyleBackColor = false;
            this.btnDodajReklamu.Click += new System.EventHandler(this.btnDodajReklamu_Click);
            // 
            // Reklame
            // 
            this.Reklame.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Reklame.FullRowSelect = true;
            this.Reklame.HideSelection = false;
            this.Reklame.Location = new System.Drawing.Point(12, 23);
            this.Reklame.Margin = new System.Windows.Forms.Padding(4);
            this.Reklame.Name = "Reklame";
            this.Reklame.Size = new System.Drawing.Size(719, 451);
            this.Reklame.TabIndex = 1;
            this.Reklame.UseCompatibleStateImageBehavior = false;
            this.Reklame.View = System.Windows.Forms.View.Details;
            this.Reklame.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cena reklame";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vreme trajanja reklame";
            this.columnHeader3.Width = 208;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reklame);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(740, 475);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reklame:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiReklamu);
            this.groupBox2.Controls.Add(this.btnIzmeniReklamu);
            this.groupBox2.Controls.Add(this.btnDodajReklamu);
            this.groupBox2.Location = new System.Drawing.Point(764, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(258, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnObrisiReklamu
            // 
            this.btnObrisiReklamu.BackColor = System.Drawing.Color.White;
            this.btnObrisiReklamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiReklamu.Location = new System.Drawing.Point(23, 95);
            this.btnObrisiReklamu.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiReklamu.Name = "btnObrisiReklamu";
            this.btnObrisiReklamu.Size = new System.Drawing.Size(212, 28);
            this.btnObrisiReklamu.TabIndex = 2;
            this.btnObrisiReklamu.Text = "Obriši reklamu";
            this.btnObrisiReklamu.UseVisualStyleBackColor = false;
            this.btnObrisiReklamu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzmeniReklamu
            // 
            this.btnIzmeniReklamu.BackColor = System.Drawing.Color.White;
            this.btnIzmeniReklamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniReklamu.Location = new System.Drawing.Point(23, 59);
            this.btnIzmeniReklamu.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniReklamu.Name = "btnIzmeniReklamu";
            this.btnIzmeniReklamu.Size = new System.Drawing.Size(212, 28);
            this.btnIzmeniReklamu.TabIndex = 1;
            this.btnIzmeniReklamu.Text = "Izmeni reklamu";
            this.btnIzmeniReklamu.UseVisualStyleBackColor = false;
            this.btnIzmeniReklamu.Click += new System.EventHandler(this.btnIzmeniReklamu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pano reklame";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reklame u novinama";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 95);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Radio i TV Reklame";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(764, 175);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(258, 139);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ReklameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1055, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReklameForm";
            this.Text = "Reklame";
            this.Load += new System.EventHandler(this.ReklameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajReklamu;
        private System.Windows.Forms.ListView Reklame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnIzmeniReklamu;
        private System.Windows.Forms.Button btnObrisiReklamu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}