﻿namespace WindowsFormsAppSelll
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this._vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._personelguncelle_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._personelguncelle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _vazgec_button
            // 
            this._vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._vazgec_button.Location = new System.Drawing.Point(271, 361);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(125, 37);
            this._vazgec_button.TabIndex = 8;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = false;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.BackColor = System.Drawing.Color.PaleGreen;
            this._kaydet_button.Location = new System.Drawing.Point(91, 361);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(125, 37);
            this._kaydet_button.TabIndex = 7;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = false;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _personelguncelle_dataGridView
            // 
            this._personelguncelle_dataGridView.AllowUserToAddRows = false;
            this._personelguncelle_dataGridView.AllowUserToDeleteRows = false;
            this._personelguncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._personelguncelle_dataGridView.Location = new System.Drawing.Point(2, 1);
            this._personelguncelle_dataGridView.Name = "_personelguncelle_dataGridView";
            this._personelguncelle_dataGridView.RowHeadersWidth = 62;
            this._personelguncelle_dataGridView.RowTemplate.Height = 28;
            this._personelguncelle_dataGridView.Size = new System.Drawing.Size(530, 338);
            this._personelguncelle_dataGridView.TabIndex = 6;
            this._personelguncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._personelguncelle_dataGridView_CellClick);
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(545, 454);
            this.ControlBox = false;
            this.Controls.Add(this._vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._personelguncelle_dataGridView);
            this.Name = "PersonelGuncelle";
            this.Text = "PersonelGuncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._personelguncelle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.DataGridView _personelguncelle_dataGridView;
    }
}