﻿namespace WindowsFormsAppSelll
{
    partial class HastaGuncelle
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
            this._hastaguncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this._kaydet_button = new System.Windows.Forms.Button();
            this._vazgec_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._hastaguncelle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _hastaguncelle_dataGridView
            // 
            this._hastaguncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._hastaguncelle_dataGridView.Location = new System.Drawing.Point(12, 12);
            this._hastaguncelle_dataGridView.Name = "_hastaguncelle_dataGridView";
            this._hastaguncelle_dataGridView.RowHeadersWidth = 62;
            this._hastaguncelle_dataGridView.RowTemplate.Height = 28;
            this._hastaguncelle_dataGridView.Size = new System.Drawing.Size(776, 393);
            this._hastaguncelle_dataGridView.TabIndex = 0;
            this._hastaguncelle_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._hastaguncelle_dataGridView_CellClick);
            // 
            // _kaydet_button
            // 
            this._kaydet_button.Location = new System.Drawing.Point(211, 425);
            this._kaydet_button.Name = "_kaydet_button";
            this._kaydet_button.Size = new System.Drawing.Size(135, 49);
            this._kaydet_button.TabIndex = 1;
            this._kaydet_button.Text = "KAYDET";
            this._kaydet_button.UseVisualStyleBackColor = true;
            this._kaydet_button.Click += new System.EventHandler(this._kaydet_button_Click);
            // 
            // _vazgec_button
            // 
            this._vazgec_button.Location = new System.Drawing.Point(378, 425);
            this._vazgec_button.Name = "_vazgec_button";
            this._vazgec_button.Size = new System.Drawing.Size(135, 49);
            this._vazgec_button.TabIndex = 2;
            this._vazgec_button.Text = "VAZGEÇ";
            this._vazgec_button.UseVisualStyleBackColor = true;
            this._vazgec_button.Click += new System.EventHandler(this._vazgec_button_Click);
            // 
            // HastaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 555);
            this.ControlBox = false;
            this.Controls.Add(this._vazgec_button);
            this.Controls.Add(this._kaydet_button);
            this.Controls.Add(this._hastaguncelle_dataGridView);
            this.Name = "HastaGuncelle";
            this.Text = "HastaGuncelle";
            this.Load += new System.EventHandler(this.HastaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._hastaguncelle_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _hastaguncelle_dataGridView;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Button _vazgec_button;
    }
}