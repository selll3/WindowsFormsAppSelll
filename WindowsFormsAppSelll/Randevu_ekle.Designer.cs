namespace WindowsFormsAppSelll
{
    partial class Randevu_ekle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu_ekle));
            this._Tarih_label = new System.Windows.Forms.Label();
            this._Saat_label = new System.Windows.Forms.Label();
            this._DoktorBilgisi_label = new System.Windows.Forms.Label();
            this._Bulgu_label = new System.Windows.Forms.Label();
            this._Acil_checkbox = new System.Windows.Forms.CheckBox();
            this._Bulgu_textBox = new System.Windows.Forms.TextBox();
            this._Ekle_button = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this._HASTANEDataSet = new WindowsFormsAppSelll._HASTANEDataSet();
            this.hASTANEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this._HASTANEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hASTANEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Tarih_label
            // 
            this._Tarih_label.AutoSize = true;
            this._Tarih_label.Location = new System.Drawing.Point(12, 27);
            this._Tarih_label.Name = "_Tarih_label";
            this._Tarih_label.Size = new System.Drawing.Size(44, 20);
            this._Tarih_label.TabIndex = 0;
            this._Tarih_label.Text = "Tarih";
            this._Tarih_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // _Saat_label
            // 
            this._Saat_label.AutoSize = true;
            this._Saat_label.Location = new System.Drawing.Point(308, 27);
            this._Saat_label.Name = "_Saat_label";
            this._Saat_label.Size = new System.Drawing.Size(43, 20);
            this._Saat_label.TabIndex = 1;
            this._Saat_label.Text = "Saat";
            this._Saat_label.Click += new System.EventHandler(this._saat_label_Click);
            // 
            // _DoktorBilgisi_label
            // 
            this._DoktorBilgisi_label.AutoSize = true;
            this._DoktorBilgisi_label.Location = new System.Drawing.Point(12, 95);
            this._DoktorBilgisi_label.Name = "_DoktorBilgisi_label";
            this._DoktorBilgisi_label.Size = new System.Drawing.Size(101, 20);
            this._DoktorBilgisi_label.TabIndex = 2;
            this._DoktorBilgisi_label.Text = "Doktor Bilgisi";
            // 
            // _Bulgu_label
            // 
            this._Bulgu_label.AutoSize = true;
            this._Bulgu_label.Location = new System.Drawing.Point(12, 155);
            this._Bulgu_label.Name = "_Bulgu_label";
            this._Bulgu_label.Size = new System.Drawing.Size(50, 20);
            this._Bulgu_label.TabIndex = 3;
            this._Bulgu_label.Text = "Bulgu";
            this._Bulgu_label.Click += new System.EventHandler(this.Bulgu_label_Click);
            // 
            // _Acil_checkbox
            // 
            this._Acil_checkbox.AutoSize = true;
            this._Acil_checkbox.BackColor = System.Drawing.Color.Red;
            this._Acil_checkbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Acil_checkbox.Location = new System.Drawing.Point(560, 33);
            this._Acil_checkbox.Name = "_Acil_checkbox";
            this._Acil_checkbox.Size = new System.Drawing.Size(60, 24);
            this._Acil_checkbox.TabIndex = 8;
            this._Acil_checkbox.Text = "Acil";
            this._Acil_checkbox.UseVisualStyleBackColor = false;
            // 
            // _Bulgu_textBox
            // 
            this._Bulgu_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Bulgu_textBox.Location = new System.Drawing.Point(119, 155);
            this._Bulgu_textBox.Multiline = true;
            this._Bulgu_textBox.Name = "_Bulgu_textBox";
            this._Bulgu_textBox.Size = new System.Drawing.Size(320, 72);
            this._Bulgu_textBox.TabIndex = 9;
            this._Bulgu_textBox.TextChanged += new System.EventHandler(this._Bulgu_textBox_TextChanged);
            // 
            // _Ekle_button
            // 
            this._Ekle_button.BackColor = System.Drawing.Color.PaleGreen;
            this._Ekle_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Ekle_button.Location = new System.Drawing.Point(274, 263);
            this._Ekle_button.Name = "_Ekle_button";
            this._Ekle_button.Size = new System.Drawing.Size(157, 42);
            this._Ekle_button.TabIndex = 10;
            this._Ekle_button.Text = "EKLE";
            this._Ekle_button.UseVisualStyleBackColor = false;
            this._Ekle_button.Click += new System.EventHandler(this._Ekle_button_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(16, 263);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(157, 42);
            this._Vazgec_button.TabIndex = 11;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // _HASTANEDataSet
            // 
            this._HASTANEDataSet.DataSetName = "_HASTANEDataSet";
            this._HASTANEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hASTANEDataSetBindingSource
            // 
            this.hASTANEDataSetBindingSource.DataSource = this._HASTANEDataSet;
            this.hASTANEDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(354, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 26);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2024, 9, 13, 10, 38, 56, 0);
            // 
            // Randevu_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsAppSelll.Properties.Resources.Green_Simple_Medical_Health_Logo__2_;
            this.ClientSize = new System.Drawing.Size(665, 436);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Ekle_button);
            this.Controls.Add(this._Bulgu_textBox);
            this.Controls.Add(this._Acil_checkbox);
            this.Controls.Add(this._Bulgu_label);
            this.Controls.Add(this._DoktorBilgisi_label);
            this.Controls.Add(this._Saat_label);
            this.Controls.Add(this._Tarih_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randevu_ekle";
            this.Text = "Randevu ekle";
            this.Load += new System.EventHandler(this.Randevu_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this._HASTANEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hASTANEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Tarih_label;
        private System.Windows.Forms.Label _Saat_label;
        private System.Windows.Forms.Label _DoktorBilgisi_label;
        private System.Windows.Forms.Label _Bulgu_label;
        private System.Windows.Forms.CheckBox _Acil_checkbox;
        private System.Windows.Forms.TextBox _Bulgu_textBox;
        private System.Windows.Forms.Button _Ekle_button;
        private System.Windows.Forms.Button _Vazgec_button;
        private System.Windows.Forms.BindingSource hASTANEDataSetBindingSource;
        private _HASTANEDataSet _HASTANEDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}