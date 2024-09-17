namespace WindowsFormsAppSelll
{
    partial class PersonelEkle
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
            this._vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._personelekle_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._personelekle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _vazgec_button
            // 
            this._vazgec_button.Location = new System.Drawing.Point(415, 452);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(136, 49);
            this._vazgec_button.TabIndex = 8;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = true;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.Location = new System.Drawing.Point(218, 452);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(135, 49);
            this._kaydet_button.TabIndex = 7;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = true;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _personelekle_dataGridView
            // 
            this._personelekle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._personelekle_dataGridView.Location = new System.Drawing.Point(12, 3);
            this._personelekle_dataGridView.Name = "_personelekle_dataGridView";
            this._personelekle_dataGridView.RowHeadersWidth = 62;
            this._personelekle_dataGridView.RowTemplate.Height = 28;
            this._personelekle_dataGridView.Size = new System.Drawing.Size(776, 388);
            this._personelekle_dataGridView.TabIndex = 6;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 750);
            this.ControlBox = false;
            this.Controls.Add(this._vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._personelekle_dataGridView);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._personelekle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.DataGridView _personelekle_dataGridView;
    }
}