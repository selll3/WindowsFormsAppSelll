namespace WindowsFormsAppSelll
{
    partial class doktorekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorekle));
            this._kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._DoktorAdi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorBransi_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(12, 284);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(102, 44);
            this._kaydet_button.TabIndex = 1;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(246, 284);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(102, 44);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _DoktorAdi_textBox
            // 
            this._DoktorAdi_textBox.Location = new System.Drawing.Point(141, 20);
            this._DoktorAdi_textBox.Name = "_DoktorAdi_textBox";
            this._DoktorAdi_textBox.Size = new System.Drawing.Size(157, 26);
            this._DoktorAdi_textBox.TabIndex = 22;
            // 
            // _DoktorSoyadi_textBox
            // 
            this._DoktorSoyadi_textBox.Location = new System.Drawing.Point(141, 77);
            this._DoktorSoyadi_textBox.Name = "_DoktorSoyadi_textBox";
            this._DoktorSoyadi_textBox.Size = new System.Drawing.Size(155, 26);
            this._DoktorSoyadi_textBox.TabIndex = 23;
            // 
            // _DoktorBransi_textBox
            // 
            this._DoktorBransi_textBox.Location = new System.Drawing.Point(141, 142);
            this._DoktorBransi_textBox.Name = "_DoktorBransi_textBox";
            this._DoktorBransi_textBox.Size = new System.Drawing.Size(155, 26);
            this._DoktorBransi_textBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Doktor Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Doktor Soyadı :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Doktor Branşı :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(141, 205);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 26);
            this.numericUpDown1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Doktorun Katı :";
            // 
            // doktorekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(387, 355);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._DoktorBransi_textBox);
            this.Controls.Add(this._DoktorSoyadi_textBox);
            this.Controls.Add(this._DoktorAdi_textBox);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Name = "doktorekle";
            this.Text = "doktorekle";
            this.Load += new System.EventHandler(this.doktorekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.TextBox _DoktorAdi_textBox;
        private System.Windows.Forms.TextBox _DoktorSoyadi_textBox;
        private System.Windows.Forms.TextBox _DoktorBransi_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}