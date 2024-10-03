namespace WindowsFormsAppSelll.MUAYENE
{
    partial class Muayeneler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._Ekle_button = new System.Windows.Forms.Button();
            this.vazgec_button = new System.Windows.Forms.Button();
            this.MuayeneTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOKTORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islendiBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuayeneTarihi,
            this.DOKTORID,
            this.HASTAID,
            this.Aciklama,
            this.islendiBilgisi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // _Ekle_button
            // 
            this._Ekle_button.Location = new System.Drawing.Point(100, 625);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(136, 45);
            this._Ekle_button.TabIndex = 1;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = true;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // vazgec_button
            // 
            this.vazgec_button.Location = new System.Drawing.Point(345, 625);
            this.vazgec_button.Name = "vazgec_button";
            this.vazgec_button.Size = new System.Drawing.Size(133, 45);
            this.vazgec_button.TabIndex = 2;
            this.vazgec_button.Text = "VAZGEÇ";
            this.vazgec_button.UseVisualStyleBackColor = true;
            this.vazgec_button.Click += new System.EventHandler(this.vazgec_button_Click);
            // 
            // MuayeneTarihi
            // 
            this.MuayeneTarihi.DataPropertyName = "MuayeneTarihi";
            this.MuayeneTarihi.HeaderText = "Muayene Tarihi";
            this.MuayeneTarihi.MinimumWidth = 8;
            this.MuayeneTarihi.Name = "MuayeneTarihi";
            // 
            // DOKTORID
            // 
            this.DOKTORID.DataPropertyName = "DOKTORID";
            this.DOKTORID.HeaderText = "Doktor id";
            this.DOKTORID.MinimumWidth = 8;
            this.DOKTORID.Name = "DOKTORID";
            // 
            // HASTAID
            // 
            this.HASTAID.DataPropertyName = "HASTAID";
            this.HASTAID.HeaderText = "Hasta id";
            this.HASTAID.MinimumWidth = 8;
            this.HASTAID.Name = "HASTAID";
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 8;
            this.Aciklama.Name = "Aciklama";
            // 
            // islendiBilgisi
            // 
            this.islendiBilgisi.DataPropertyName = "islendiBilgisi";
            this.islendiBilgisi.HeaderText = "İşlendi Bilgisi";
            this.islendiBilgisi.MinimumWidth = 8;
            this.islendiBilgisi.Name = "islendiBilgisi";
            // 
            // Muayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 715);
            this.ControlBox = false;
            this.Controls.Add(this.vazgec_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Muayeneler";
            this.Text = "Muayeneler";
            this.Load += new System.EventHandler(this.Muayeneler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button vazgec_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuayeneTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOKTORID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn islendiBilgisi;
    }
}