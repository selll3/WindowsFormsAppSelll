namespace WindowsFormsAppSelll
{
    partial class HastaEkle
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
            this._hastaekle_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._hastaekle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _vazgec_button
            // 
            this._vazgec_button.Location = new System.Drawing.Point(416, 420);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(136, 49);
            this._vazgec_button.TabIndex = 5;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = true;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.Location = new System.Drawing.Point(244, 420);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(135, 49);
            this._kaydet_button.TabIndex = 4;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = true;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _hastaekle_dataGridView
            // 
            this._hastaekle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._hastaekle_dataGridView.Location = new System.Drawing.Point(12, 12);
            this._hastaekle_dataGridView.Name = "_hastaekle_dataGridView";
            this._hastaekle_dataGridView.RowHeadersWidth = 62;
            this._hastaekle_dataGridView.RowTemplate.Height = 28;
            this._hastaekle_dataGridView.Size = new System.Drawing.Size(776, 388);
            this._hastaekle_dataGridView.TabIndex = 3;
            // 
            // HastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 583);
            this.ControlBox = false;
            this.Controls.Add(this._vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._hastaekle_dataGridView);
            this.Name = "HastaEkle";
            this.Text = "HastaEkle";
            this.Load += new System.EventHandler(this.HastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._hastaekle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.DataGridView _hastaekle_dataGridView;
    }
}