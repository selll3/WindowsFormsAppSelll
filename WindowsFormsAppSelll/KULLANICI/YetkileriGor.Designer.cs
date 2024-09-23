namespace WindowsFormsAppSelll.KULLANICI
{
    partial class YetkileriGor
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
            this._yetkilerigor_dataGridView = new System.Windows.Forms.DataGridView();
            this._Kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _yetkilerigor_dataGridView
            // 
            this._yetkilerigor_dataGridView.AllowUserToAddRows = false;
            this._yetkilerigor_dataGridView.AllowUserToDeleteRows = false;
            this._yetkilerigor_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._yetkilerigor_dataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._yetkilerigor_dataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._yetkilerigor_dataGridView.Location = new System.Drawing.Point(1, 0);
            this._yetkilerigor_dataGridView.Name = "_yetkilerigor_dataGridView";
            this._yetkilerigor_dataGridView.RowHeadersWidth = 62;
            this._yetkilerigor_dataGridView.RowTemplate.Height = 28;
            this._yetkilerigor_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._yetkilerigor_dataGridView.Size = new System.Drawing.Size(572, 344);
            this._yetkilerigor_dataGridView.TabIndex = 0;
            this._yetkilerigor_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _Kaydet_button
            // 
            this._Kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Kaydet_button.Location = new System.Drawing.Point(105, 361);
            this._Kaydet_button.Name = "_Kaydet_button";
            this._Kaydet_button.Size = new System.Drawing.Size(122, 44);
            this._Kaydet_button.TabIndex = 1;
            this._Kaydet_button.Text = "KAYDET";
            this._Kaydet_button.UseVisualStyleBackColor = false;
            this._Kaydet_button.Click += new System.EventHandler(this._Kaydet_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._Vazgec_button.Location = new System.Drawing.Point(288, 361);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(122, 44);
            this._Vazgec_button.TabIndex = 2;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // YetkileriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Kaydet_button);
            this.Controls.Add(this._yetkilerigor_dataGridView);
            this.Name = "YetkileriGor";
            this.Text = "YetkileriGor";
            this.Load += new System.EventHandler(this.YetkileriGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView _yetkilerigor_dataGridView;
        private System.Windows.Forms.Button _Kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}