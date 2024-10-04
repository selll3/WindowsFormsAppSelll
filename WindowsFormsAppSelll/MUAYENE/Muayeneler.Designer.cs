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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muayeneler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MuayeneTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOKTORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islendiBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Ekle_button = new System.Windows.Forms.Button();
            this.vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bauhaus 93", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuayeneTarihi,
            this.DOKTORID,
            this.HASTAID,
            this.Aciklama,
            this.islendiBilgisi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bauhaus 93", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
            // MuayeneTarihi
            // 
            this.MuayeneTarihi.DataPropertyName = "MuayeneTarihi";
            this.MuayeneTarihi.HeaderText = "Muayene Tarihi";
            this.MuayeneTarihi.MinimumWidth = 8;
            this.MuayeneTarihi.Name = "MuayeneTarihi";
            this.MuayeneTarihi.ReadOnly = true;
            // 
            // DOKTORID
            // 
            this.DOKTORID.DataPropertyName = "DOKTORID";
            this.DOKTORID.HeaderText = "Doktor id";
            this.DOKTORID.MinimumWidth = 8;
            this.DOKTORID.Name = "DOKTORID";
            this.DOKTORID.ReadOnly = true;
            // 
            // HASTAID
            // 
            this.HASTAID.DataPropertyName = "HASTAID";
            this.HASTAID.HeaderText = "Hasta id";
            this.HASTAID.MinimumWidth = 8;
            this.HASTAID.Name = "HASTAID";
            this.HASTAID.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 8;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // islendiBilgisi
            // 
            this.islendiBilgisi.DataPropertyName = "islendiBilgisi";
            this.islendiBilgisi.HeaderText = "İşlendi Bilgisi";
            this.islendiBilgisi.MinimumWidth = 8;
            this.islendiBilgisi.Name = "islendiBilgisi";
            this.islendiBilgisi.ReadOnly = true;
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9F);
            this._Ekle_button.Location = new System.Drawing.Point(100, 625);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(136, 45);
            this._Ekle_button.TabIndex = 1;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // vazgec_button
            // 
            this.vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this.vazgec_button.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9F);
            this.vazgec_button.Location = new System.Drawing.Point(345, 625);
            this.vazgec_button.Name = "vazgec_button";
            this.vazgec_button.Size = new System.Drawing.Size(133, 45);
            this.vazgec_button.TabIndex = 2;
            this.vazgec_button.Text = "VAZGEÇ";
            this.vazgec_button.UseVisualStyleBackColor = false;
            this.vazgec_button.Click += new System.EventHandler(this.vazgec_button_Click);
            // 
            // Muayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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