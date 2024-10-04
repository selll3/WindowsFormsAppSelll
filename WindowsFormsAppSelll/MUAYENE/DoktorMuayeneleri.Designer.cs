namespace WindowsFormsAppSelll.MUAYENE
{
    partial class DoktorMuayeneleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorMuayeneleri));
            this._DoktorMuayeneleri_dataGridView = new System.Windows.Forms.DataGridView();
            this.MuayeneTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOKTORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islendiBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DoktorMuayeneleri_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _DoktorMuayeneleri_dataGridView
            // 
            this._DoktorMuayeneleri_dataGridView.AllowUserToAddRows = false;
            this._DoktorMuayeneleri_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._DoktorMuayeneleri_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._DoktorMuayeneleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DoktorMuayeneleri_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuayeneTarihi,
            this.DOKTORID,
            this.HASTAID,
            this.Aciklama,
            this.islendiBilgisi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._DoktorMuayeneleri_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._DoktorMuayeneleri_dataGridView.Location = new System.Drawing.Point(2, 3);
            this._DoktorMuayeneleri_dataGridView.Name = "_DoktorMuayeneleri_dataGridView";
            this._DoktorMuayeneleri_dataGridView.RowHeadersWidth = 62;
            this._DoktorMuayeneleri_dataGridView.RowTemplate.Height = 28;
            this._DoktorMuayeneleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DoktorMuayeneleri_dataGridView.Size = new System.Drawing.Size(700, 402);
            this._DoktorMuayeneleri_dataGridView.TabIndex = 0;
            this._DoktorMuayeneleri_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this._DoktorMuayeneleri_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorMuayeneleri_dataGridView_CellDoubleClick);
            // 
            // MuayeneTarihi
            // 
            this.MuayeneTarihi.DataPropertyName = "MuayeneTarihi";
            this.MuayeneTarihi.HeaderText = "Muayene Tarihi";
            this.MuayeneTarihi.MinimumWidth = 8;
            this.MuayeneTarihi.Name = "MuayeneTarihi";
            this.MuayeneTarihi.Width = 150;
            // 
            // DOKTORID
            // 
            this.DOKTORID.DataPropertyName = "DOKTORID";
            this.DOKTORID.HeaderText = "Doktor id";
            this.DOKTORID.MinimumWidth = 8;
            this.DOKTORID.Name = "DOKTORID";
            this.DOKTORID.Width = 150;
            // 
            // HASTAID
            // 
            this.HASTAID.DataPropertyName = "HASTAID";
            this.HASTAID.HeaderText = "Hasta id";
            this.HASTAID.MinimumWidth = 8;
            this.HASTAID.Name = "HASTAID";
            this.HASTAID.Width = 150;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 8;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Width = 150;
            // 
            // islendiBilgisi
            // 
            this.islendiBilgisi.DataPropertyName = "islendiBilgisi";
            this.islendiBilgisi.HeaderText = "İşlendi Bilgisi";
            this.islendiBilgisi.MinimumWidth = 8;
            this.islendiBilgisi.Name = "islendiBilgisi";
            this.islendiBilgisi.Width = 150;
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Vazgec_button.Location = new System.Drawing.Point(571, 422);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(120, 40);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // DoktorMuayeneleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 473);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._DoktorMuayeneleri_dataGridView);
            this.Name = "DoktorMuayeneleri";
            this.Text = "DoktorMuayeneleri";
            this.Load += new System.EventHandler(this.DoktorMuayeneleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DoktorMuayeneleri_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DoktorMuayeneleri_dataGridView;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuayeneTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOKTORID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn islendiBilgisi;
    }
}