namespace WindowsFormsAppSelll
{
    partial class doktorekle
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
            this._kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(681, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // _kaydet_button
            // 
            this._kaydet_button.Location = new System.Drawing.Point(12, 490);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(173, 53);
            this._kaydet_button.TabIndex = 1;
            this._kaydet_button.Text = "kaydet";
            this._kaydet_button.UseVisualStyleBackColor = true;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(520, 504);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(173, 53);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // doktorekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 685);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "doktorekle";
            this.Text = "doktorekle";
            this.Load += new System.EventHandler(this.doktorekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}