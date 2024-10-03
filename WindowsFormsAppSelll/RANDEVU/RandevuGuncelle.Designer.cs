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
            this._vazgec_button = new System.Windows.Forms.Button();
            this._kaydet_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this._HastaBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._doktorBilgisi_comboBox = new System.Windows.Forms.ComboBox();
            this._Bulgu_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this._RandevuTarihi_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._RandevuSaati_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _vazgec_button
            // 
            this._vazgec_button.BackColor = System.Drawing.Color.Khaki;
            this._vazgec_button.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._vazgec_button.Location = new System.Drawing.Point(306, 35);
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
            this._kaydet_button.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._kaydet_button.Location = new System.Drawing.Point(100, 35);
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
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 97);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hasta Bilgisi :";
            // 
            // _HastaBilgisi_comboBox
            // 
            this._HastaBilgisi_comboBox.FormattingEnabled = true;
            this._HastaBilgisi_comboBox.Location = new System.Drawing.Point(154, 177);
            this._HastaBilgisi_comboBox.Name = "_HastaBilgisi_comboBox";
            this._HastaBilgisi_comboBox.Size = new System.Drawing.Size(239, 28);
            this._HastaBilgisi_comboBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bulgu :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doktor Bilgisi :";
            // 
            // _doktorBilgisi_comboBox
            // 
            this._doktorBilgisi_comboBox.FormattingEnabled = true;
            this._doktorBilgisi_comboBox.Location = new System.Drawing.Point(154, 125);
            this._doktorBilgisi_comboBox.Name = "_doktorBilgisi_comboBox";
            this._doktorBilgisi_comboBox.Size = new System.Drawing.Size(239, 28);
            this._doktorBilgisi_comboBox.TabIndex = 20;
            // 
            // _Bulgu_textBox
            // 
            this._Bulgu_textBox.Location = new System.Drawing.Point(154, 242);
            this._Bulgu_textBox.Multiline = true;
            this._Bulgu_textBox.Name = "_Bulgu_textBox";
            this._Bulgu_textBox.Size = new System.Drawing.Size(341, 99);
            this._Bulgu_textBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Randevu Saati :";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(16, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 26);
            this.label.TabIndex = 17;
            this.label.Text = "Randevu Tarihi :";
            // 
            // _RandevuTarihi_dateTimePicker
            // 
            this._RandevuTarihi_dateTimePicker.Location = new System.Drawing.Point(154, 20);
            this._RandevuTarihi_dateTimePicker.Name = "_RandevuTarihi_dateTimePicker";
            this._RandevuTarihi_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this._RandevuTarihi_dateTimePicker.TabIndex = 16;
            // 
            // _RandevuSaati_dateTimePicker
            // 
            this._RandevuSaati_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._RandevuSaati_dateTimePicker.Location = new System.Drawing.Point(154, 69);
            this._RandevuSaati_dateTimePicker.Name = "_RandevuSaati_dateTimePicker";
            this._RandevuSaati_dateTimePicker.Size = new System.Drawing.Size(105, 26);
            this._RandevuSaati_dateTimePicker.TabIndex = 15;
            // 
            // RandevuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(530, 470);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this._HastaBilgisi_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._doktorBilgisi_comboBox);
            this.Controls.Add(this._Bulgu_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this._RandevuTarihi_dateTimePicker);
            this.Controls.Add(this._RandevuSaati_dateTimePicker);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RandevuGuncelle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RandevuGuncelle";
            this.Load += new System.EventHandler(this.RandevuGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _vazgec_button;
        private System.Windows.Forms.Button _kaydet_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _HastaBilgisi_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _doktorBilgisi_comboBox;
        private System.Windows.Forms.TextBox _Bulgu_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker _RandevuTarihi_dateTimePicker;
        private System.Windows.Forms.DateTimePicker _RandevuSaati_dateTimePicker;
    }
}