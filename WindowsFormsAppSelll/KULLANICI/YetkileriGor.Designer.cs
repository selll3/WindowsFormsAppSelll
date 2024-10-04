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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkileriGor));
            this._yetkilerigor_dataGridView = new System.Windows.Forms.DataGridView();
            this.FormAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Kaydet_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _yetkilerigor_dataGridView
            // 
            this._yetkilerigor_dataGridView.AllowUserToAddRows = false;
            this._yetkilerigor_dataGridView.AllowUserToDeleteRows = false;
            this._yetkilerigor_dataGridView.AllowUserToOrderColumns = true;
            this._yetkilerigor_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._yetkilerigor_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._yetkilerigor_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._yetkilerigor_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormAdi});
            this._yetkilerigor_dataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(163)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._yetkilerigor_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._yetkilerigor_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._yetkilerigor_dataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._yetkilerigor_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._yetkilerigor_dataGridView.Name = "_yetkilerigor_dataGridView";
            this._yetkilerigor_dataGridView.RowHeadersWidth = 62;
            this._yetkilerigor_dataGridView.RowTemplate.Height = 28;
            this._yetkilerigor_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._yetkilerigor_dataGridView.Size = new System.Drawing.Size(479, 663);
            this._yetkilerigor_dataGridView.TabIndex = 0;
            this._yetkilerigor_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormAdi
            // 
            this.FormAdi.DataPropertyName = "FormAdi";
            this.FormAdi.HeaderText = "Form Adı";
            this.FormAdi.MinimumWidth = 8;
            this.FormAdi.Name = "FormAdi";
            // 
            // _Kaydet_button
            // 
            this._Kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Kaydet_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Kaydet_button.Location = new System.Drawing.Point(84, 16);
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
            this._Vazgec_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this._Vazgec_button.Location = new System.Drawing.Point(296, 16);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(122, 44);
            this._Vazgec_button.TabIndex = 2;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Vazgec_button);
            this.panel1.Controls.Add(this._Kaydet_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 94);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // YetkileriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 759);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._yetkilerigor_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "YetkileriGor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "YetkileriGor";
            this.Load += new System.EventHandler(this.YetkileriGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this._yetkilerigor_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView _yetkilerigor_dataGridView;
        private System.Windows.Forms.Button _Kaydet_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormAdi;
    }
}