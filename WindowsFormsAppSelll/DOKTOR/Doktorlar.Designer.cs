namespace WindowsFormsAppSelll
{
    partial class Doktorlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar));
            this._Sil_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._Doktorlar_dataGridView = new System.Windows.Forms.DataGridView();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._GUNCELLE_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Enabled = false;
            this._Sil_button.Location = new System.Drawing.Point(542, 21);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(110, 41);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(177, 21);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(110, 41);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Doktorlar_dataGridView
            // 
            this._Doktorlar_dataGridView.AllowUserToAddRows = false;
            this._Doktorlar_dataGridView.AllowUserToDeleteRows = false;
            this._Doktorlar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Doktorlar_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._Doktorlar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Doktorlar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Doktorlar_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._Doktorlar_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._Doktorlar_dataGridView.Name = "_Doktorlar_dataGridView";
            this._Doktorlar_dataGridView.RowHeadersWidth = 62;
            this._Doktorlar_dataGridView.RowTemplate.Height = 28;
            this._Doktorlar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._Doktorlar_dataGridView.Size = new System.Drawing.Size(665, 568);
            this._Doktorlar_dataGridView.TabIndex = 23;
            this._Doktorlar_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._Doktorlar_dataGridView_CellContentClick);
            this._Doktorlar_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this._Doktorlar_dataGridView_RowValidating);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Enabled = false;
            this._Ekle_button.Location = new System.Drawing.Point(3, 21);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(110, 41);
            this._Ekle_button.TabIndex = 39;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _GUNCELLE_button
            // 
            this._GUNCELLE_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._GUNCELLE_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._GUNCELLE_button.Enabled = false;
            this._GUNCELLE_button.Location = new System.Drawing.Point(363, 21);
            this._GUNCELLE_button.Name = "_GUNCELLE_button";
            this._GUNCELLE_button.Size = new System.Drawing.Size(110, 41);
            this._GUNCELLE_button.TabIndex = 40;
            this._GUNCELLE_button.Text = "GÜNCELLE";
            this._GUNCELLE_button.UseVisualStyleBackColor = false;
            this._GUNCELLE_button.Click += new System.EventHandler(this._GUNCELLE_button_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this._Ekle_button);
            this.panel1.Controls.Add(this._GUNCELLE_button);
            this.panel1.Controls.Add(this._Sil_button);
            this.panel1.Controls.Add(this._Vazgec_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 65);
            this.panel1.TabIndex = 41;
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._Doktorlar_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Doktorlar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Doktorlar_dataGridView;
        public System.Windows.Forms.Button _Sil_button;
        public System.Windows.Forms.Button _Ekle_button;
        public System.Windows.Forms.Button _GUNCELLE_button;
        private System.Windows.Forms.Panel panel1;
    }
}