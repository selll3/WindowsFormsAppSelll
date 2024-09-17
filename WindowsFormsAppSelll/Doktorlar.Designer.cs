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
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _Sil_button
            // 
            this._Sil_button.BackColor = System.Drawing.Color.Red;
            this._Sil_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Sil_button.Location = new System.Drawing.Point(29, 619);
            this._Sil_button.Name = "_Sil_button";
            this._Sil_button.Size = new System.Drawing.Size(106, 40);
            this._Sil_button.TabIndex = 2;
            this._Sil_button.Text = "SİL";
            this._Sil_button.UseVisualStyleBackColor = false;
            this._Sil_button.Click += new System.EventHandler(this._Sil_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(758, 619);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(97, 37);
            this._Vazgec_button.TabIndex = 20;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _Doktorlar_dataGridView
            // 
            this._Doktorlar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Doktorlar_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Doktorlar_dataGridView.Location = new System.Drawing.Point(29, 42);
            this._Doktorlar_dataGridView.Name = "_Doktorlar_dataGridView";
            this._Doktorlar_dataGridView.RowHeadersWidth = 62;
            this._Doktorlar_dataGridView.RowTemplate.Height = 28;
            this._Doktorlar_dataGridView.Size = new System.Drawing.Size(839, 526);
            this._Doktorlar_dataGridView.TabIndex = 23;
            this._Doktorlar_dataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this._Doktorlar_dataGridView_RowValidating);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(379, 619);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(93, 41);
            this._Ekle_button.TabIndex = 39;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1039, 880);
            this.ControlBox = false;
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._Doktorlar_dataGridView);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Sil_button);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Doktorlar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _Sil_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.DataGridView _Doktorlar_dataGridView;
        private System.Windows.Forms.Button _Ekle_button;
    }
}