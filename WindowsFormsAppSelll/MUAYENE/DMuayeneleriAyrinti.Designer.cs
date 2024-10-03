namespace WindowsFormsAppSelll.MUAYENE
{
    partial class DMuayeneleriAyrinti
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
            this._hastaAdi_textBox = new System.Windows.Forms.TextBox();
            this._hastaSoyadi_textBox = new System.Windows.Forms.TextBox();
            this._hastaYasi_textBox = new System.Windows.Forms.TextBox();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MuayeneTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUAYENEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _hastaAdi_textBox
            // 
            this._hastaAdi_textBox.Enabled = false;
            this._hastaAdi_textBox.Location = new System.Drawing.Point(3, 3);
            this._hastaAdi_textBox.Name = "_hastaAdi_textBox";
            this._hastaAdi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaAdi_textBox.TabIndex = 0;
            // 
            // _hastaSoyadi_textBox
            // 
            this._hastaSoyadi_textBox.Enabled = false;
            this._hastaSoyadi_textBox.Location = new System.Drawing.Point(3, 50);
            this._hastaSoyadi_textBox.Name = "_hastaSoyadi_textBox";
            this._hastaSoyadi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaSoyadi_textBox.TabIndex = 1;
            // 
            // _hastaYasi_textBox
            // 
            this._hastaYasi_textBox.Enabled = false;
            this._hastaYasi_textBox.Location = new System.Drawing.Point(3, 105);
            this._hastaYasi_textBox.Name = "_hastaYasi_textBox";
            this._hastaYasi_textBox.Size = new System.Drawing.Size(197, 26);
            this._hastaYasi_textBox.TabIndex = 2;
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(327, 380);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(120, 40);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuayeneTarihi,
            this.MUAYENEID,
            this.Aciklama});
            this.dataGridView1.Location = new System.Drawing.Point(3, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 192);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MuayeneTarihi
            // 
            this.MuayeneTarihi.DataPropertyName = "MuayeneTarihi";
            this.MuayeneTarihi.HeaderText = "Muayene Tarihi";
            this.MuayeneTarihi.MinimumWidth = 8;
            this.MuayeneTarihi.Name = "MuayeneTarihi";
            this.MuayeneTarihi.ReadOnly = true;
            this.MuayeneTarihi.Width = 150;
            // 
            // MUAYENEID
            // 
            this.MUAYENEID.DataPropertyName = "MUAYENEID";
            this.MUAYENEID.HeaderText = "Muayene id";
            this.MUAYENEID.MinimumWidth = 8;
            this.MUAYENEID.Name = "MUAYENEID";
            this.MUAYENEID.ReadOnly = true;
            this.MUAYENEID.Width = 150;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.MinimumWidth = 8;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 150;
            // 
            // DMuayeneleriAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 432);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._hastaYasi_textBox);
            this.Controls.Add(this._hastaSoyadi_textBox);
            this.Controls.Add(this._hastaAdi_textBox);
            this.Name = "DMuayeneleriAyrinti";
            this.Text = "DMuayeneleriAyrinti";
            this.Load += new System.EventHandler(this.DMuayeneleriAyrinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _hastaAdi_textBox;
        private System.Windows.Forms.TextBox _hastaSoyadi_textBox;
        private System.Windows.Forms.TextBox _hastaYasi_textBox;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuayeneTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUAYENEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
    }
}