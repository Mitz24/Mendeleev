namespace Tabel_Perodic_CS
{
    partial class CalculatorMasaMolara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMasaMolara));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxCalculator = new System.Windows.Forms.PictureBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxCopy = new System.Windows.Forms.PictureBox();
            this.lblMm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalculator)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picBoxCalculator);
            this.panel1.Controls.Add(this.txtFormula);
            this.panel1.Location = new System.Drawing.Point(52, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 71);
            this.panel1.TabIndex = 4;
            // 
            // picBoxCalculator
            // 
            this.picBoxCalculator.Image = global::Tabel_Perodic_CS.Properties.Resources.Calculator;
            this.picBoxCalculator.Location = new System.Drawing.Point(367, 13);
            this.picBoxCalculator.Name = "picBoxCalculator";
            this.picBoxCalculator.Size = new System.Drawing.Size(43, 42);
            this.picBoxCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCalculator.TabIndex = 18;
            this.picBoxCalculator.TabStop = false;
            this.picBoxCalculator.Click += new System.EventHandler(this.picBoxCalculator_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormula.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(16, 20);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(328, 28);
            this.txtFormula.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.picBoxCopy);
            this.panel2.Controls.Add(this.lblMm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(52, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 71);
            this.panel2.TabIndex = 5;
            // 
            // picBoxCopy
            // 
            this.picBoxCopy.Image = global::Tabel_Perodic_CS.Properties.Resources.CopyIcon;
            this.picBoxCopy.Location = new System.Drawing.Point(368, 17);
            this.picBoxCopy.Name = "picBoxCopy";
            this.picBoxCopy.Size = new System.Drawing.Size(43, 42);
            this.picBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCopy.TabIndex = 2;
            this.picBoxCopy.TabStop = false;
            this.picBoxCopy.Click += new System.EventHandler(this.picBoxCopy_Click);
            // 
            // lblMm
            // 
            this.lblMm.AutoSize = true;
            this.lblMm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMm.Location = new System.Drawing.Point(134, 28);
            this.lblMm.Name = "lblMm";
            this.lblMm.Size = new System.Drawing.Size(40, 19);
            this.lblMm.TabIndex = 0;
            this.lblMm.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa molara: ";
            // 
            // CalculatorMasaMolara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorMasaMolara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorMasaMolara";
            this.Load += new System.EventHandler(this.CalculatorMasaMolara_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCalculator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxCopy;
        private System.Windows.Forms.Label lblMm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.PictureBox picBoxCalculator;
    }
}