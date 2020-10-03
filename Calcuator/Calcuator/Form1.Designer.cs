namespace Calcuator
{
    partial class FormCalculator
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
            this.labelNilaib = new System.Windows.Forms.Label();
            this.textBoxNilaib = new System.Windows.Forms.TextBox();
            this.textBoxNilaia = new System.Windows.Forms.TextBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.groupBoxHasil = new System.Windows.Forms.GroupBox();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.labelNilaia = new System.Windows.Forms.Label();
            this.groupBoxHasil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNilaib
            // 
            this.labelNilaib.AutoSize = true;
            this.labelNilaib.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNilaib.Location = new System.Drawing.Point(38, 71);
            this.labelNilaib.Name = "labelNilaib";
            this.labelNilaib.Size = new System.Drawing.Size(36, 13);
            this.labelNilaib.TabIndex = 1;
            this.labelNilaib.Text = "Nilai b";
            // 
            // textBoxNilaib
            // 
            this.textBoxNilaib.Location = new System.Drawing.Point(108, 68);
            this.textBoxNilaib.Name = "textBoxNilaib";
            this.textBoxNilaib.Size = new System.Drawing.Size(183, 20);
            this.textBoxNilaib.TabIndex = 2;
            // 
            // textBoxNilaia
            // 
            this.textBoxNilaia.Location = new System.Drawing.Point(108, 42);
            this.textBoxNilaia.Name = "textBoxNilaia";
            this.textBoxNilaia.Size = new System.Drawing.Size(183, 20);
            this.textBoxNilaia.TabIndex = 3;
            // 
            // buttonHitung
            // 
            this.buttonHitung.ForeColor = System.Drawing.Color.Crimson;
            this.buttonHitung.Location = new System.Drawing.Point(127, 94);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(147, 41);
            this.buttonHitung.TabIndex = 4;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // groupBoxHasil
            // 
            this.groupBoxHasil.Controls.Add(this.listHasil);
            this.groupBoxHasil.Location = new System.Drawing.Point(28, 152);
            this.groupBoxHasil.Name = "groupBoxHasil";
            this.groupBoxHasil.Size = new System.Drawing.Size(269, 190);
            this.groupBoxHasil.TabIndex = 5;
            this.groupBoxHasil.TabStop = false;
            this.groupBoxHasil.Text = "Hasil :";
            // 
            // listHasil
            // 
            this.listHasil.FormattingEnabled = true;
            this.listHasil.Location = new System.Drawing.Point(7, 20);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(256, 160);
            this.listHasil.TabIndex = 0;
            // 
            // labelNilaia
            // 
            this.labelNilaia.AutoSize = true;
            this.labelNilaia.Location = new System.Drawing.Point(41, 42);
            this.labelNilaia.Name = "labelNilaia";
            this.labelNilaia.Size = new System.Drawing.Size(36, 13);
            this.labelNilaia.TabIndex = 6;
            this.labelNilaia.Text = "Nilai a";
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 354);
            this.Controls.Add(this.labelNilaia);
            this.Controls.Add(this.groupBoxHasil);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.textBoxNilaia);
            this.Controls.Add(this.textBoxNilaib);
            this.Controls.Add(this.labelNilaib);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.Click += new System.EventHandler(this.buttonHitung_Click);
            this.groupBoxHasil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNilaib;
        private System.Windows.Forms.TextBox textBoxNilaib;
        private System.Windows.Forms.TextBox textBoxNilaia;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.GroupBox groupBoxHasil;
        private System.Windows.Forms.ListBox listHasil;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label labelNilaia;
    }
}

