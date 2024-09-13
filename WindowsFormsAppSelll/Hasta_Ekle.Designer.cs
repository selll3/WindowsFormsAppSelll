namespace WindowsFormsAppSelll
{
    partial class Hasta_Ekle
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
            this._HastaAdi_label = new System.Windows.Forms.Label();
            this._HastaSoyadi_label = new System.Windows.Forms.Label();
            this._HastaYasi_label = new System.Windows.Forms.Label();
            this._HastaAdi_textBox = new System.Windows.Forms.TextBox();
            this._HastaSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._HastaYasi_textBox = new System.Windows.Forms.TextBox();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Ekle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _HastaAdi_label
            // 
            this._HastaAdi_label.AutoSize = true;
            this._HastaAdi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaAdi_label.Location = new System.Drawing.Point(27, 37);
            this._HastaAdi_label.Name = "_HastaAdi_label";
            this._HastaAdi_label.Size = new System.Drawing.Size(79, 20);
            this._HastaAdi_label.TabIndex = 0;
            this._HastaAdi_label.Text = "Hasta Adı";
            this._HastaAdi_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // _HastaSoyadi_label
            // 
            this._HastaSoyadi_label.AutoSize = true;
            this._HastaSoyadi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaSoyadi_label.Location = new System.Drawing.Point(27, 80);
            this._HastaSoyadi_label.Name = "_HastaSoyadi_label";
            this._HastaSoyadi_label.Size = new System.Drawing.Size(104, 20);
            this._HastaSoyadi_label.TabIndex = 1;
            this._HastaSoyadi_label.Text = "Hasta Soyadı";
            // 
            // _HastaYasi_label
            // 
            this._HastaYasi_label.AutoSize = true;
            this._HastaYasi_label.BackColor = System.Drawing.SystemColors.Window;
            this._HastaYasi_label.Location = new System.Drawing.Point(27, 138);
            this._HastaYasi_label.Name = "_HastaYasi_label";
            this._HastaYasi_label.Size = new System.Drawing.Size(87, 20);
            this._HastaYasi_label.TabIndex = 2;
            this._HastaYasi_label.Text = "Hasta Yaşı";
            // 
            // _HastaAdi_textBox
            // 
            this._HastaAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaAdi_textBox.Location = new System.Drawing.Point(140, 34);
            this._HastaAdi_textBox.Name = "_HastaAdi_textBox";
            this._HastaAdi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaAdi_textBox.TabIndex = 3;
            this._HastaAdi_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _HastaSoyadi_textBox
            // 
            this._HastaSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaSoyadi_textBox.Location = new System.Drawing.Point(140, 80);
            this._HastaSoyadi_textBox.Name = "_HastaSoyadi_textBox";
            this._HastaSoyadi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaSoyadi_textBox.TabIndex = 4;
            // 
            // _HastaYasi_textBox
            // 
            this._HastaYasi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastaYasi_textBox.Location = new System.Drawing.Point(140, 138);
            this._HastaYasi_textBox.Name = "_HastaYasi_textBox";
            this._HastaYasi_textBox.Size = new System.Drawing.Size(120, 26);
            this._HastaYasi_textBox.TabIndex = 5;
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Location = new System.Drawing.Point(34, 265);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(112, 34);
            this._Vazgec_button.TabIndex = 6;
            this._Vazgec_button.Text = "Vazgeç";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.LimeGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(257, 265);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(121, 36);
            this._Ekle_button.TabIndex = 7;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hasta_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(428, 407);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._HastaYasi_textBox);
            this.Controls.Add(this._HastaSoyadi_textBox);
            this.Controls.Add(this._HastaAdi_textBox);
            this.Controls.Add(this._HastaYasi_label);
            this.Controls.Add(this._HastaSoyadi_label);
            this.Controls.Add(this._HastaAdi_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Hasta_Ekle";
            this.Text = "Hasta_Ekle";
            this.Load += new System.EventHandler(this.Hasta_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _HastaAdi_label;
        private System.Windows.Forms.Label _HastaSoyadi_label;
        private System.Windows.Forms.Label _HastaYasi_label;
        private System.Windows.Forms.TextBox _HastaAdi_textBox;
        private System.Windows.Forms.TextBox _HastaSoyadi_textBox;
        private System.Windows.Forms.TextBox _HastaYasi_textBox;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Button _Ekle_button;
    }
}