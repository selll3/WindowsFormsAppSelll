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
            this._Vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DoktorMuayeneleri_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _DoktorMuayeneleri_dataGridView
            // 
            this._DoktorMuayeneleri_dataGridView.AllowUserToAddRows = false;
            this._DoktorMuayeneleri_dataGridView.AllowUserToDeleteRows = false;
            this._DoktorMuayeneleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DoktorMuayeneleri_dataGridView.Location = new System.Drawing.Point(2, 3);
            this._DoktorMuayeneleri_dataGridView.Name = "_DoktorMuayeneleri_dataGridView";
            this._DoktorMuayeneleri_dataGridView.RowHeadersWidth = 62;
            this._DoktorMuayeneleri_dataGridView.RowTemplate.Height = 28;
            this._DoktorMuayeneleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DoktorMuayeneleri_dataGridView.Size = new System.Drawing.Size(682, 402);
            this._DoktorMuayeneleri_dataGridView.TabIndex = 0;
            this._DoktorMuayeneleri_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this._DoktorMuayeneleri_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorMuayeneleri_dataGridView_CellDoubleClick);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(560, 439);
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
            this.ClientSize = new System.Drawing.Size(684, 529);
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
    }
}