namespace WindowsFormsAppSelll
{
    partial class DoktorGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGuncelle));
            this._DoktorlarGuncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this._dkayıt_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DoktorlarGuncelle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _DoktorlarGuncelle_dataGridView
            // 
            this._DoktorlarGuncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DoktorlarGuncelle_dataGridView.Location = new System.Drawing.Point(12, 12);
            this._DoktorlarGuncelle_dataGridView.Name = "_DoktorlarGuncelle_dataGridView";
            this._DoktorlarGuncelle_dataGridView.RowHeadersWidth = 62;
            this._DoktorlarGuncelle_dataGridView.RowTemplate.Height = 28;
            this._DoktorlarGuncelle_dataGridView.Size = new System.Drawing.Size(707, 401);
            this._DoktorlarGuncelle_dataGridView.TabIndex = 0;
            this._DoktorlarGuncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorlarGuncelle_dataGridView_CellClick);
            this._DoktorlarGuncelle_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorlarGuncelle_dataGridView_CellContentClick);
            // 
            // _dkayıt_button
            // 
            this._dkayıt_button.BackColor = System.Drawing.Color.PaleGreen;
            this._dkayıt_button.Location = new System.Drawing.Point(186, 438);
            this._dkayıt_button.Name = "_dkayıt_button";
            this._dkayıt_button.Size = new System.Drawing.Size(132, 53);
            this._dkayıt_button.TabIndex = 1;
            this._dkayıt_button.Text = "KAYDET";
            this._dkayıt_button.UseVisualStyleBackColor = false;
            this._dkayıt_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(360, 438);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(132, 53);
            this._Vazgec_button.TabIndex = 22;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // DoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 552);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._dkayıt_button);
            this.Controls.Add(this._DoktorlarGuncelle_dataGridView);
            this.Name = "DoktorGuncelle";
            this.Text = "DoktorGuncelle";
            this.Load += new System.EventHandler(this.DoktorGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DoktorlarGuncelle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DoktorlarGuncelle_dataGridView;
        private System.Windows.Forms.Button _dkayıt_button;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}