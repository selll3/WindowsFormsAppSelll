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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._DoktorlarGuncelle_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _DoktorlarGuncelle_dataGridView
            // 
            this._DoktorlarGuncelle_dataGridView.AllowUserToAddRows = false;
            this._DoktorlarGuncelle_dataGridView.AllowUserToDeleteRows = false;
            this._DoktorlarGuncelle_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._DoktorlarGuncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._DoktorlarGuncelle_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._DoktorlarGuncelle_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._DoktorlarGuncelle_dataGridView.Name = "_DoktorlarGuncelle_dataGridView";
            this._DoktorlarGuncelle_dataGridView.RowHeadersWidth = 62;
            this._DoktorlarGuncelle_dataGridView.RowTemplate.Height = 28;
            this._DoktorlarGuncelle_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._DoktorlarGuncelle_dataGridView.Size = new System.Drawing.Size(521, 602);
            this._DoktorlarGuncelle_dataGridView.TabIndex = 0;
            this._DoktorlarGuncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorlarGuncelle_dataGridView_CellClick);
            this._DoktorlarGuncelle_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._DoktorlarGuncelle_dataGridView_CellContentClick);
            // 
            // _dkayıt_button
            // 
            this._dkayıt_button.BackColor = System.Drawing.Color.PaleGreen;
            this._dkayıt_button.Location = new System.Drawing.Point(103, 22);
            this._dkayıt_button.Name = "_dkayıt_button";
            this._dkayıt_button.Size = new System.Drawing.Size(113, 36);
            this._dkayıt_button.TabIndex = 1;
            this._dkayıt_button.Text = "KAYDET";
            this._dkayıt_button.UseVisualStyleBackColor = false;
            this._dkayıt_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(300, 22);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(112, 36);
            this._Vazgec_button.TabIndex = 22;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._dkayıt_button);
            this.panel1.Controls.Add(this._Vazgec_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 79);
            this.panel1.TabIndex = 23;
            // 
            // DoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(521, 687);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._DoktorlarGuncelle_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DoktorGuncelle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DoktorGuncelle";
            this.Load += new System.EventHandler(this.DoktorGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DoktorlarGuncelle_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _DoktorlarGuncelle_dataGridView;
        private System.Windows.Forms.Button _dkayıt_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Panel panel1;
    }
}