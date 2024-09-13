namespace WindowsFormsAppSelll
{
    partial class Personel_ekle
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
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Gorevi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._PersonelAdi_textBox = new System.Windows.Forms.TextBox();
            this._Gorevi_label = new System.Windows.Forms.Label();
            this._PersonelSoyadi_label = new System.Windows.Forms.Label();
            this._PersonelAdi_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(41, 276);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(148, 45);
            this._Vazgec_button.TabIndex = 15;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(248, 276);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(148, 45);
            this._Ekle_button.TabIndex = 14;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Gorevi_textBox
            // 
            this._Gorevi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Gorevi_textBox.Location = new System.Drawing.Point(137, 175);
            this._Gorevi_textBox.Name = "_Gorevi_textBox";
            this._Gorevi_textBox.Size = new System.Drawing.Size(186, 26);
            this._Gorevi_textBox.TabIndex = 13;
            // 
            // _PersonelSoyadi_textBox
            // 
            this._PersonelSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelSoyadi_textBox.Location = new System.Drawing.Point(166, 89);
            this._PersonelSoyadi_textBox.Name = "_PersonelSoyadi_textBox";
            this._PersonelSoyadi_textBox.Size = new System.Drawing.Size(170, 26);
            this._PersonelSoyadi_textBox.TabIndex = 12;
            // 
            // _PersonelAdi_textBox
            // 
            this._PersonelAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelAdi_textBox.Location = new System.Drawing.Point(153, 14);
            this._PersonelAdi_textBox.Name = "_PersonelAdi_textBox";
            this._PersonelAdi_textBox.Size = new System.Drawing.Size(170, 26);
            this._PersonelAdi_textBox.TabIndex = 11;
            // 
            // _Gorevi_label
            // 
            this._Gorevi_label.AutoSize = true;
            this._Gorevi_label.Location = new System.Drawing.Point(37, 181);
            this._Gorevi_label.Name = "_Gorevi_label";
            this._Gorevi_label.Size = new System.Drawing.Size(73, 20);
            this._Gorevi_label.TabIndex = 10;
            this._Gorevi_label.Text = "GÖREVİ";
            // 
            // _PersonelSoyadi_label
            // 
            this._PersonelSoyadi_label.AutoSize = true;
            this._PersonelSoyadi_label.Location = new System.Drawing.Point(37, 92);
            this._PersonelSoyadi_label.Name = "_PersonelSoyadi_label";
            this._PersonelSoyadi_label.Size = new System.Drawing.Size(123, 20);
            this._PersonelSoyadi_label.TabIndex = 9;
            this._PersonelSoyadi_label.Text = "Personel Soyadı";
            // 
            // _PersonelAdi_label
            // 
            this._PersonelAdi_label.AutoSize = true;
            this._PersonelAdi_label.Location = new System.Drawing.Point(37, 20);
            this._PersonelAdi_label.Name = "_PersonelAdi_label";
            this._PersonelAdi_label.Size = new System.Drawing.Size(98, 20);
            this._PersonelAdi_label.TabIndex = 8;
            this._PersonelAdi_label.Text = "Personel Adı";
            // 
            // Personel_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(452, 412);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._Gorevi_textBox);
            this.Controls.Add(this._PersonelSoyadi_textBox);
            this.Controls.Add(this._PersonelAdi_textBox);
            this.Controls.Add(this._Gorevi_label);
            this.Controls.Add(this._PersonelSoyadi_label);
            this.Controls.Add(this._PersonelAdi_label);
            this.Name = "Personel_ekle";
            this.Text = "Personel_ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.TextBox _Gorevi_textBox;
        private System.Windows.Forms.TextBox _PersonelSoyadi_textBox;
        private System.Windows.Forms.TextBox _PersonelAdi_textBox;
        private System.Windows.Forms.Label _Gorevi_label;
        private System.Windows.Forms.Label _PersonelSoyadi_label;
        private System.Windows.Forms.Label _PersonelAdi_label;
    }
}