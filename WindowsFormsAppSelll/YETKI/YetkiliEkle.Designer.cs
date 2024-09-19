namespace WindowsFormsAppSelll.YETKI
{
    partial class YetkiliEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this._personel_comboBox = new System.Windows.Forms.ComboBox();
            this._formlar_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel Adı Soyadı :";
            // 
            // _personel_comboBox
            // 
            this._personel_comboBox.FormattingEnabled = true;
            this._personel_comboBox.Location = new System.Drawing.Point(193, 27);
            this._personel_comboBox.Name = "_personel_comboBox";
            this._personel_comboBox.Size = new System.Drawing.Size(238, 28);
            this._personel_comboBox.TabIndex = 3;
            // 
            // _formlar_comboBox
            // 
            this._formlar_comboBox.FormattingEnabled = true;
            this._formlar_comboBox.Location = new System.Drawing.Point(193, 97);
            this._formlar_comboBox.Name = "_formlar_comboBox";
            this._formlar_comboBox.Size = new System.Drawing.Size(238, 28);
            this._formlar_comboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Formlar";
            // 
            // YetkiliEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 365);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._formlar_comboBox);
            this.Controls.Add(this._personel_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "YetkiliEkle";
            this.Text = "Yetkili Ekle";
            this.Load += new System.EventHandler(this.Yetkiler_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _personel_comboBox;
        private System.Windows.Forms.ComboBox _formlar_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}