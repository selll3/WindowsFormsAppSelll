namespace WindowsFormsAppSelll
{
    partial class Hastalar
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
            this._HastalariListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Hastalar_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _HastalariListele_button
            // 
            this._HastalariListele_button.BackColor = System.Drawing.Color.Aquamarine;
            this._HastalariListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._HastalariListele_button.Location = new System.Drawing.Point(627, 441);
            this._HastalariListele_button.Name = "_HastalariListele_button";
            this._HastalariListele_button.Size = new System.Drawing.Size(149, 43);
            this._HastalariListele_button.TabIndex = 0;
            this._HastalariListele_button.Text = "Hastaları Listele";
            this._HastalariListele_button.UseVisualStyleBackColor = false;
            this._HastalariListele_button.Click += new System.EventHandler(this._HastalariListele_button_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(12, 441);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(149, 43);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "Sil";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(221, 441);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(149, 43);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Hastalar_dataGridView
            // 
            this._Hastalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Hastalar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Hastalar_dataGridView.Location = new System.Drawing.Point(12, 42);
            this._Hastalar_dataGridView.Name = "_Hastalar_dataGridView";
            this._Hastalar_dataGridView.RowHeadersWidth = 62;
            this._Hastalar_dataGridView.RowTemplate.Height = 28;
            this._Hastalar_dataGridView.Size = new System.Drawing.Size(788, 367);
            this._Hastalar_dataGridView.TabIndex = 23;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(429, 441);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(149, 43);
            this._GUNCELLE_button.TabIndex = 30;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            // 
            // Hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(821, 568);
            this.ControlBox = false;
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Hastalar_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._HastalariListele_button);
            this.Name = "Hastalar";
            this.Text = "Hastalar";
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _HastalariListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Hastalar_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
    }
}