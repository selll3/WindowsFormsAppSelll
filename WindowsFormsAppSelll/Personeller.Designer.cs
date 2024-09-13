namespace WindowsFormsAppSelll
{
    partial class Personeller
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
            this._PersonelilListele_button = new System.Windows.Forms.Button();
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Personeller_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Personeller_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _PersonelilListele_button
            // 
            this._PersonelilListele_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this._PersonelilListele_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._PersonelilListele_button.Location = new System.Drawing.Point(739, 457);
            this._PersonelilListele_button.Name = "_PersonelilListele_button";
            this._PersonelilListele_button.Size = new System.Drawing.Size(169, 42);
            this._PersonelilListele_button.TabIndex = 0;
            this._PersonelilListele_button.Text = "Personelleri Listele";
            this._PersonelilListele_button.UseVisualStyleBackColor = false;
            this._PersonelilListele_button.Click += new System.EventHandler(this._PersonelilListele_button_Click);
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(16, 456);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(138, 43);
            this._Sil_button.TabIndex = 1;
            this._Sil_button.Text = "Sil";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(257, 456);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(138, 42);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Personeller_dataGridView
            // 
            this._Personeller_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Personeller_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Personeller_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Personeller_dataGridView.Location = new System.Drawing.Point(12, 29);
            this._Personeller_dataGridView.Name = "_Personeller_dataGridView";
            this._Personeller_dataGridView.RowHeadersWidth = 62;
            this._Personeller_dataGridView.RowTemplate.Height = 28;
            this._Personeller_dataGridView.Size = new System.Drawing.Size(896, 380);
            this._Personeller_dataGridView.TabIndex = 23;
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Location = new System.Drawing.Point(485, 458);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(138, 41);
            this._GUNCELLE_button.TabIndex = 29;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(968, 564);
            this.ControlBox = false;
            this.Controls.Add(this._GUNCELLE_button);
            this.Controls.Add(this._Personeller_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Controls.Add(this._PersonelilListele_button);
            this.Name = "Personeller";
            this.Text = "Personeller";
            ((System.ComponentModel.ISupportInitialize)(this._Personeller_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _PersonelilListele_button;
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Personeller_dataGridView;
        private System.Windows.Forms.Button _GUNCELLE_button;
    }
}