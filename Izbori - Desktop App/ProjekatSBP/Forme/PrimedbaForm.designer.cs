
namespace ProjekatSBP.Forme
{
    partial class PrimedbaForm
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
            this.txbPrimedba = new System.Windows.Forms.TextBox();
            this.btnPrimedba = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPrimedba
            // 
            this.txbPrimedba.Location = new System.Drawing.Point(6, 36);
            this.txbPrimedba.Name = "txbPrimedba";
            this.txbPrimedba.Size = new System.Drawing.Size(306, 24);
            this.txbPrimedba.TabIndex = 0;
            // 
            // btnPrimedba
            // 
            this.btnPrimedba.BackColor = System.Drawing.Color.White;
            this.btnPrimedba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimedba.Location = new System.Drawing.Point(235, 105);
            this.btnPrimedba.Name = "btnPrimedba";
            this.btnPrimedba.Size = new System.Drawing.Size(89, 32);
            this.btnPrimedba.TabIndex = 2;
            this.btnPrimedba.Text = "Dodaj Primedbu";
            this.btnPrimedba.UseVisualStyleBackColor = false;
            this.btnPrimedba.Click += new System.EventHandler(this.btnPrimedba_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPrimedba);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primedba:";
            // 
            // PrimedbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(355, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrimedba);
            this.Name = "PrimedbaForm";
            this.Text = "Primedba";
            this.Load += new System.EventHandler(this.PrimedbaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbPrimedba;
        private System.Windows.Forms.Button btnPrimedba;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}