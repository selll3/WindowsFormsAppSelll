namespace WindowsFormsAppSelll
{
    partial class Doktor_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor_ekle));
            this._DoktorAdi_label = new System.Windows.Forms.Label();
            this._DoktorSoyadi_label = new System.Windows.Forms.Label();
            this._DoktorunBranşi_label = new System.Windows.Forms.Label();
            this._DoktorAdi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorBranşi_textBox = new System.Windows.Forms.TextBox();
            this._DoktorunKati_label = new System.Windows.Forms.Label();
            this._DoktorunKati_textBox = new System.Windows.Forms.TextBox();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _DoktorAdi_label
            // 
            this._DoktorAdi_label.AutoSize = true;
            this._DoktorAdi_label.Location = new System.Drawing.Point(12, 19);
            this._DoktorAdi_label.Name = "_DoktorAdi_label";
            this._DoktorAdi_label.Size = new System.Drawing.Size(84, 20);
            this._DoktorAdi_label.TabIndex = 0;
            this._DoktorAdi_label.Text = "Doktor Adı";
            // 
            // _DoktorSoyadi_label
            // 
            this._DoktorSoyadi_label.AutoSize = true;
            this._DoktorSoyadi_label.Location = new System.Drawing.Point(12, 61);
            this._DoktorSoyadi_label.Name = "_DoktorSoyadi_label";
            this._DoktorSoyadi_label.Size = new System.Drawing.Size(109, 20);
            this._DoktorSoyadi_label.TabIndex = 1;
            this._DoktorSoyadi_label.Text = "Doktor Soyadı";
            // 
            // _DoktorunBranşi_label
            // 
            this._DoktorunBranşi_label.AutoSize = true;
            this._DoktorunBranşi_label.Location = new System.Drawing.Point(12, 117);
            this._DoktorunBranşi_label.Name = "_DoktorunBranşi_label";
            this._DoktorunBranşi_label.Size = new System.Drawing.Size(124, 20);
            this._DoktorunBranşi_label.TabIndex = 2;
            this._DoktorunBranşi_label.Text = "Doktorun Branşı";
            this._DoktorunBranşi_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // _DoktorAdi_textBox
            // 
            this._DoktorAdi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorAdi_textBox.Location = new System.Drawing.Point(142, 13);
            this._DoktorAdi_textBox.Name = "_DoktorAdi_textBox";
            this._DoktorAdi_textBox.Size = new System.Drawing.Size(212, 26);
            this._DoktorAdi_textBox.TabIndex = 3;
            // 
            // _DoktorSoyadi_textBox
            // 
            this._DoktorSoyadi_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._DoktorSoyadi_textBox.Location = new System.Drawing.Point(142, 61);
            this._DoktorSoyadi_textBox.Name = "_DoktorSoyadi_textBox";
            this._DoktorSoyadi_textBox.Size = new System.Drawing.Size(201, 26);
            this._DoktorSoyadi_textBox.TabIndex = 4;
            // 
            // _DoktorBranşi_textBox
            // 
            this._DoktorBranşi_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorBranşi_textBox.Location = new System.Drawing.Point(142, 111);
            this._DoktorBranşi_textBox.Name = "_DoktorBranşi_textBox";
            this._DoktorBranşi_textBox.Size = new System.Drawing.Size(256, 26);
            this._DoktorBranşi_textBox.TabIndex = 5;
            // 
            // _DoktorunKati_label
            // 
            this._DoktorunKati_label.AutoSize = true;
            this._DoktorunKati_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorunKati_label.Location = new System.Drawing.Point(372, 16);
            this._DoktorunKati_label.Name = "_DoktorunKati_label";
            this._DoktorunKati_label.Size = new System.Drawing.Size(180, 20);
            this._DoktorunKati_label.TabIndex = 6;
            this._DoktorunKati_label.Text = "Doktorun bulunduğu kat";
            // 
            // _DoktorunKati_textBox
            // 
            this._DoktorunKati_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._DoktorunKati_textBox.Location = new System.Drawing.Point(558, 16);
            this._DoktorunKati_textBox.Name = "_DoktorunKati_textBox";
            this._DoktorunKati_textBox.Size = new System.Drawing.Size(66, 26);
            this._DoktorunKati_textBox.TabIndex = 7;
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(459, 190);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(165, 47);
            this._Ekle_button.TabIndex = 8;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(16, 190);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(165, 47);
            this._Vazgec_button.TabIndex = 9;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click_1);
            // 
            // Doktor_ekle
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(655, 294);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._DoktorunKati_textBox);
            this.Controls.Add(this._DoktorunKati_label);
            this.Controls.Add(this._DoktorBranşi_textBox);
            this.Controls.Add(this._DoktorSoyadi_textBox);
            this.Controls.Add(this._DoktorAdi_textBox);
            this.Controls.Add(this._DoktorunBranşi_label);
            this.Controls.Add(this._DoktorSoyadi_label);
            this.Controls.Add(this._DoktorAdi_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doktor_ekle";
            this.Text = "Doktor Ekle";
            this.Load += new System.EventHandler(this.Doktor_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _DoktorAdi_label;
        private System.Windows.Forms.Label _DoktorSoyadi_label;
        private System.Windows.Forms.Label _DoktorunBranşi_label;
        private System.Windows.Forms.TextBox _DoktorAdi_textBox;
        private System.Windows.Forms.TextBox _DoktorSoyadi_textBox;
        private System.Windows.Forms.TextBox _DoktorBranşi_textBox;
        private System.Windows.Forms.Label _DoktorunKati_label;
        private System.Windows.Forms.TextBox _DoktorunKati_textBox;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}