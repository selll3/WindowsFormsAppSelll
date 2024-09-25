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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastalar));
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Hastalar_dataGridView = new System.Windows.Forms.DataGridView();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this._Ekle_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Enabled = false;
            this._Sil_button.Location = new System.Drawing.Point(553, 37);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(122, 38);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(192, 37);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(122, 38);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Hastalar_dataGridView
            // 
            this._Hastalar_dataGridView.AllowUserToAddRows = false;
            this._Hastalar_dataGridView.AllowUserToDeleteRows = false;
            this._Hastalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Hastalar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Hastalar_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._Hastalar_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._Hastalar_dataGridView.Name = "_Hastalar_dataGridView";
            this._Hastalar_dataGridView.ReadOnly = true;
            this._Hastalar_dataGridView.RowHeadersWidth = 62;
            this._Hastalar_dataGridView.RowTemplate.Height = 28;
            this._Hastalar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._Hastalar_dataGridView.Size = new System.Drawing.Size(678, 578);
            this._Hastalar_dataGridView.TabIndex = 23;
            this._Hastalar_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._Hastalar_dataGridView_CellContentClick);
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Enabled = false;
            this._GUNCELLE_button.Location = new System.Drawing.Point(374, 37);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(122, 38);
            this._GUNCELLE_button.TabIndex = 30;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Enabled = false;
            this._Ekle_button.Location = new System.Drawing.Point(0, 37);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(122, 38);
            this._Ekle_button.TabIndex = 37;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Ekle_button);
            this.panel1.Controls.Add(this._GUNCELLE_button);
            this.panel1.Controls.Add(this._Sil_button);
            this.panel1.Controls.Add(this._Vazgec_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 120);
            this.panel1.TabIndex = 38;
            // 
            // Hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 696);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._Hastalar_dataGridView);
            this.Name = "Hastalar";
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.Hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Hastalar_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Hastalar_dataGridView;
        public System.Windows.Forms.Button _Sil_button;
        public System.Windows.Forms.Button _GUNCELLE_button;
        public System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Panel panel1;
    }
}