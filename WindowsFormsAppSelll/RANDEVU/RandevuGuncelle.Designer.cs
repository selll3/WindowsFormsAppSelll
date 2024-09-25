namespace WindowsFormsAppSelll
{
    partial class RandevuGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuGuncelle));
            this._randevuguncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this._vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._randevuguncelle_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _randevuguncelle_dataGridView
            // 
            this._randevuguncelle_dataGridView.AllowUserToAddRows = false;
            this._randevuguncelle_dataGridView.AllowUserToDeleteRows = false;
            this._randevuguncelle_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._randevuguncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._randevuguncelle_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._randevuguncelle_dataGridView.Location = new System.Drawing.Point(0, 0);
            this._randevuguncelle_dataGridView.Name = "_randevuguncelle_dataGridView";
            this._randevuguncelle_dataGridView.RowHeadersWidth = 62;
            this._randevuguncelle_dataGridView.RowTemplate.Height = 28;
            this._randevuguncelle_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._randevuguncelle_dataGridView.Size = new System.Drawing.Size(580, 598);
            this._randevuguncelle_dataGridView.TabIndex = 0;
            this._randevuguncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._randevuguncelle_dataGridView_CellClick);
            // 
            // _vazgec_button
            // 
            this._vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._vazgec_button.Location = new System.Drawing.Point(319, 35);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(125, 40);
            this._vazgec_button.TabIndex = 4;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = false;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(125, 35);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(125, 40);
            this._kaydet_button.TabIndex = 3;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._kaydet_button);
            this.panel1.Controls.Add(this._vazgec_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 97);
            this.panel1.TabIndex = 5;
            // 
            // RandevuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(580, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._randevuguncelle_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RandevuGuncelle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RandevuGuncelle";
            this.Load += new System.EventHandler(this.RandevuGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._randevuguncelle_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _randevuguncelle_dataGridView;
        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Panel panel1;
    }
}