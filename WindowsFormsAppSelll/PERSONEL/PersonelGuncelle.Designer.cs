namespace WindowsFormsAppSelll
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this._vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._personelguncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelGorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._personelguncelle_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _vazgec_button
            // 
            this._vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._vazgec_button.Location = new System.Drawing.Point(283, 27);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(125, 37);
            this._vazgec_button.TabIndex = 8;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = false;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(111, 27);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(125, 37);
            this._kaydet_button.TabIndex = 7;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _personelguncelle_dataGridView
            // 
            this._personelguncelle_dataGridView.AllowUserToAddRows = false;
            this._personelguncelle_dataGridView.AllowUserToDeleteRows = false;
            this._personelguncelle_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._personelguncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._personelguncelle_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelAdi,
            this.PersonelSoyadi,
            this.PersonelGorev});
            this._personelguncelle_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._personelguncelle_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._personelguncelle_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._personelguncelle_dataGridView.Name = "_personelguncelle_dataGridView";
            this._personelguncelle_dataGridView.RowHeadersWidth = 62;
            this._personelguncelle_dataGridView.RowTemplate.Height = 28;
            this._personelguncelle_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._personelguncelle_dataGridView.Size = new System.Drawing.Size(561, 541);
            this._personelguncelle_dataGridView.TabIndex = 6;
            this._personelguncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._personelguncelle_dataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._vazgec_button);
            this.panel1.Controls.Add(this._kaydet_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 94);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.DataPropertyName = "PersonelAdi";
            this.PersonelAdi.HeaderText = "Personel Adı";
            this.PersonelAdi.MinimumWidth = 8;
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // PersonelSoyadi
            // 
            this.PersonelSoyadi.DataPropertyName = "PersonelSoyadi";
            this.PersonelSoyadi.HeaderText = "Personel Soyadi";
            this.PersonelSoyadi.MinimumWidth = 8;
            this.PersonelSoyadi.Name = "PersonelSoyadi";
            // 
            // PersonelGorev
            // 
            this.PersonelGorev.DataPropertyName = "PersonelGorev";
            this.PersonelGorev.HeaderText = "Personel Görevi";
            this.PersonelGorev.MinimumWidth = 8;
            this.PersonelGorev.Name = "PersonelGorev";
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 635);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._personelguncelle_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PersonelGuncelle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PersonelGuncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._personelguncelle_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.DataGridView _personelguncelle_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelGorev;
    }
}