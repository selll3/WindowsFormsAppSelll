namespace WindowsFormsAppSelll
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._PersonelAdi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelGorev_textBox = new System.Windows.Forms.TextBox();
            this._PersonelSoyadi_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(194, 247);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(128, 42);
            this._Vazgec_button.TabIndex = 23;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(14, 247);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(131, 42);
            this._kaydet_button.TabIndex = 22;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Personel Soyadı :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Personel Görev :";
            // 
            // _PersonelAdi_textBox
            // 
            this._PersonelAdi_textBox.Location = new System.Drawing.Point(161, 22);
            this._PersonelAdi_textBox.Name = "_PersonelAdi_textBox";
            this._PersonelAdi_textBox.Size = new System.Drawing.Size(174, 26);
            this._PersonelAdi_textBox.TabIndex = 27;
            // 
            // _PersonelGorev_textBox
            // 
            this._PersonelGorev_textBox.Location = new System.Drawing.Point(161, 161);
            this._PersonelGorev_textBox.Name = "_PersonelGorev_textBox";
            this._PersonelGorev_textBox.Size = new System.Drawing.Size(174, 26);
            this._PersonelGorev_textBox.TabIndex = 28;
            // 
            // _PersonelSoyadi_textBox
            // 
            this._PersonelSoyadi_textBox.Location = new System.Drawing.Point(161, 88);
            this._PersonelSoyadi_textBox.Name = "_PersonelSoyadi_textBox";
            this._PersonelSoyadi_textBox.Size = new System.Drawing.Size(174, 26);
            this._PersonelSoyadi_textBox.TabIndex = 29;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.ControlBox = false;
            this.Controls.Add(this._PersonelSoyadi_textBox);
            this.Controls.Add(this._PersonelGorev_textBox);
            this.Controls.Add(this._PersonelAdi_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _PersonelAdi_textBox;
        private System.Windows.Forms.TextBox _PersonelGorev_textBox;
        private System.Windows.Forms.TextBox _PersonelSoyadi_textBox;
    }
}