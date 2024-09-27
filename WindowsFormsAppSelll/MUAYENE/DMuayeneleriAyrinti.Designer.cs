namespace WindowsFormsAppSelll.MUAYENE
{
    partial class DMuayeneleriAyrinti
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
            this._hastaAdi_textBox = new System.Windows.Forms.TextBox();
            this._hastaSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._hastaYasi_textBox = new System.Windows.Forms.TextBox();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _hastaAdi_textBox
            // 
            this._hastaAdi_textBox.Location = new System.Drawing.Point(64, 40);
            this._hastaAdi_textBox.Name = "_hastaAdi_textBox";
            this._hastaAdi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaAdi_textBox.TabIndex = 0;
            // 
            // _hastaSoyadi_textBox
            // 
            this._hastaSoyadi_textBox.Location = new System.Drawing.Point(64, 110);
            this._hastaSoyadi_textBox.Name = "_hastaSoyadi_textBox";
            this._hastaSoyadi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaSoyadi_textBox.TabIndex = 1;
            // 
            // _hastaYasi_textBox
            // 
            this._hastaYasi_textBox.Location = new System.Drawing.Point(64, 182);
            this._hastaYasi_textBox.Name = "_hastaYasi_textBox";
            this._hastaYasi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaYasi_textBox.TabIndex = 2;
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(640, 379);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(120, 40);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // DMuayeneleriAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._hastaYasi_textBox);
            this.Controls.Add(this._hastaSoyadi_textBox);
            this.Controls.Add(this._hastaAdi_textBox);
            this.Name = "DMuayeneleriAyrinti";
            this.Text = "DMuayeneleriAyrinti";
            this.Load += new System.EventHandler(this.DMuayeneleriAyrinti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _hastaAdi_textBox;
        private System.Windows.Forms.TextBox _hastaSoyadi_textBox;
        private System.Windows.Forms.TextBox _hastaYasi_textBox;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}