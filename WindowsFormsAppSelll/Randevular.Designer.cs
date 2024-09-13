namespace WindowsFormsAppSelll
{
    partial class Randevular
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
            this._RandevuListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Randevular_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Randevular_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _RandevuListele_button
            // 
            this._RandevuListele_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this._RandevuListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._RandevuListele_button.Location = new System.Drawing.Point(619, 444);
            this._RandevuListele_button.Name = "_RandevuListele_button";
            this._RandevuListele_button.Size = new System.Drawing.Size(181, 45);
            this._RandevuListele_button.TabIndex = 0;
            this._RandevuListele_button.Text = "Randevuları Listele";
            this._RandevuListele_button.UseVisualStyleBackColor = false;
            this._RandevuListele_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(27, 446);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(126, 43);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "Sil";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(202, 444);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(126, 43);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Randevular_dataGridView
            // 
            this._Randevular_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Randevular_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Randevular_dataGridView.Location = new System.Drawing.Point(27, 30);
            this._Randevular_dataGridView.Name = "_Randevular_dataGridView";
            this._Randevular_dataGridView.RowHeadersWidth = 62;
            this._Randevular_dataGridView.RowTemplate.Height = 28;
            this._Randevular_dataGridView.Size = new System.Drawing.Size(773, 377);
            this._Randevular_dataGridView.TabIndex = 22;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(425, 448);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(126, 41);
            this._GUNCELLE_button.TabIndex = 29;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(834, 546);
            this.ControlBox = false;
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Randevular_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._RandevuListele_button);
            this.Name = "Randevular";
            this.Text = "Randevular";
            ((System.ComponentModel.ISupportInitialize)(this._Randevular_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _RandevuListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Randevular_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
    }
}