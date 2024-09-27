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
            this._DoktorMuayeneleri_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._DoktorMuayeneleri_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _DoktorMuayeneleri_dataGridView
            // 
            this._DoktorMuayeneleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DoktorMuayeneleri_dataGridView.Location = new System.Drawing.Point(2, 3);
            this._DoktorMuayeneleri_dataGridView.Name = "_DoktorMuayeneleri_dataGridView";
            this._DoktorMuayeneleri_dataGridView.RowHeadersWidth = 62;
            this._DoktorMuayeneleri_dataGridView.RowTemplate.Height = 28;
            this._DoktorMuayeneleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DoktorMuayeneleri_dataGridView.Size = new System.Drawing.Size(786, 402);
            this._DoktorMuayeneleri_dataGridView.TabIndex = 0;
            this._DoktorMuayeneleri_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DoktorMuayeneleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 610);
            this.ControlBox = false;
            this.Controls.Add(this._DoktorMuayeneleri_dataGridView);
            this.Name = "DoktorMuayeneleri";
            this.Text = "DoktorMuayeneleri";
            this.Load += new System.EventHandler(this.DoktorMuayeneleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DoktorMuayeneleri_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DoktorMuayeneleri_dataGridView;
    }
}