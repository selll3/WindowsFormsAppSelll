namespace WindowsFormsAppSelll
{
    partial class MuayeneEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._HastaBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._RandevuBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._DoktorBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._aciklama_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Bilgisi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Randevu Bilgisi :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor Bilgisi :";
            // 
            // _HastaBilgisi_comboBox
            // 
            this._HastaBilgisi_comboBox.FormattingEnabled = true;
            this._HastaBilgisi_comboBox.Location = new System.Drawing.Point(153, 21);
            this._HastaBilgisi_comboBox.Name = "_HastaBilgisi_comboBox";
            this._HastaBilgisi_comboBox.Size = new System.Drawing.Size(249, 28);
            this._HastaBilgisi_comboBox.TabIndex = 3;
            this._HastaBilgisi_comboBox.SelectedIndexChanged += new System.EventHandler(this._HastaBilgisi_comboBox_SelectedIndexChanged);
            // 
            // _RandevuBilgisi_comboBox
            // 
            this._RandevuBilgisi_comboBox.FormattingEnabled = true;
            this._RandevuBilgisi_comboBox.Location = new System.Drawing.Point(153, 71);
            this._RandevuBilgisi_comboBox.Name = "_RandevuBilgisi_comboBox";
            this._RandevuBilgisi_comboBox.Size = new System.Drawing.Size(249, 28);
            this._RandevuBilgisi_comboBox.TabIndex = 4;
            // 
            // _DoktorBilgisi_comboBox
            // 
            this._DoktorBilgisi_comboBox.FormattingEnabled = true;
            this._DoktorBilgisi_comboBox.Location = new System.Drawing.Point(153, 132);
            this._DoktorBilgisi_comboBox.Name = "_DoktorBilgisi_comboBox";
            this._DoktorBilgisi_comboBox.Size = new System.Drawing.Size(248, 28);
            this._DoktorBilgisi_comboBox.TabIndex = 5;
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(10, 332);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(127, 39);
            this._kaydet_button.TabIndex = 6;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.Location = new System.Drawing.Point(274, 332);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(127, 39);
            this._Vazgec_button.TabIndex = 7;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = true;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama :";
            // 
            // _aciklama_textBox
            // 
            this._aciklama_textBox.Location = new System.Drawing.Point(153, 200);
            this._aciklama_textBox.Multiline = true;
            this._aciklama_textBox.Name = "_aciklama_textBox";
            this._aciklama_textBox.Size = new System.Drawing.Size(249, 80);
            this._aciklama_textBox.TabIndex = 9;
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 410);
            this.ControlBox = false;
            this.Controls.Add(this._aciklama_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._DoktorBilgisi_comboBox);
            this.Controls.Add(this._RandevuBilgisi_comboBox);
            this.Controls.Add(this._HastaBilgisi_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneEkle";
            this.Text = "Muayene";
            this.Load += new System.EventHandler(this.MuayeneEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _HastaBilgisi_comboBox;
        private System.Windows.Forms.ComboBox _RandevuBilgisi_comboBox;
        private System.Windows.Forms.ComboBox _DoktorBilgisi_comboBox;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _aciklama_textBox;
    }
}