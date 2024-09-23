namespace WindowsFormsAppSelll.KULLANICI
{
    partial class ForeignKeyCheckForm
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
            this._resultDataGridView = new System.Windows.Forms.DataGridView();
            this._CheckForeignKeyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _resultDataGridView
            // 
            this._resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultDataGridView.Location = new System.Drawing.Point(107, 32);
            this._resultDataGridView.Name = "_resultDataGridView";
            this._resultDataGridView.RowHeadersWidth = 62;
            this._resultDataGridView.RowTemplate.Height = 28;
            this._resultDataGridView.Size = new System.Drawing.Size(575, 208);
            this._resultDataGridView.TabIndex = 0;
            // 
            // _CheckForeignKeyButton
            // 
            this._CheckForeignKeyButton.Location = new System.Drawing.Point(341, 328);
            this._CheckForeignKeyButton.Name = "_CheckForeignKeyButton";
            this._CheckForeignKeyButton.Size = new System.Drawing.Size(384, 47);
            this._CheckForeignKeyButton.TabIndex = 1;
            this._CheckForeignKeyButton.Text = "KISITLAMAYI KONTROL ET";
            this._CheckForeignKeyButton.UseVisualStyleBackColor = true;
            this._CheckForeignKeyButton.Click += new System.EventHandler(this._CheckForeignKeyButton_Click);
            // 
            // ForeignKeyCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._CheckForeignKeyButton);
            this.Controls.Add(this._resultDataGridView);
            this.Name = "ForeignKeyCheckForm";
            this.Text = "ForeignKeyCheckForm";
            this.Load += new System.EventHandler(this.ForeignKeyCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _resultDataGridView;
        private System.Windows.Forms.Button _CheckForeignKeyButton;
    }
}