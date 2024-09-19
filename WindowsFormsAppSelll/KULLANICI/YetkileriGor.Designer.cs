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
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _yetkilerigor_dataGridView
            // 
            this._yetkilerigor_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._yetkilerigor_dataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._yetkilerigor_dataGridView.Location = new System.Drawing.Point(12, 12);
            this._yetkilerigor_dataGridView.Name = "_yetkilerigor_dataGridView";
            this._yetkilerigor_dataGridView.RowHeadersWidth = 62;
            this._yetkilerigor_dataGridView.RowTemplate.Height = 28;
            this._yetkilerigor_dataGridView.Size = new System.Drawing.Size(713, 383);
            this._yetkilerigor_dataGridView.TabIndex = 0;
            this._yetkilerigor_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // YetkileriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(746, 481);
            this.ControlBox = false;
            this.Controls.Add(this._yetkilerigor_dataGridView);
            this.Name = "YetkileriGor";
            this.Text = "YetkileriGor";
            this.Load += new System.EventHandler(this.YetkileriGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _yetkilerigor_dataGridView;
    }
}