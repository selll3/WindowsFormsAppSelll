namespace WindowsFormsAppSelll.KULLANICI
{
    partial class Kullanıcılar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcılar));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._kullaniciTürü_comboBox = new System.Windows.Forms.ComboBox();
            this._Parola_textBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdi_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(215, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Türü :";
            // 
            // _kullaniciTürü_comboBox
            // 
            this._kullaniciTürü_comboBox.FormattingEnabled = true;
            this._kullaniciTürü_comboBox.Items.AddRange(new object[] {
            "admin",
            "Muhasebe/İK",
            "Personel",
            "Doktor"});
            this._kullaniciTürü_comboBox.Location = new System.Drawing.Point(142, 161);
            this._kullaniciTürü_comboBox.Name = "_kullaniciTürü_comboBox";
            this._kullaniciTürü_comboBox.Size = new System.Drawing.Size(206, 28);
            this._kullaniciTürü_comboBox.TabIndex = 4;
            // 
            // _Parola_textBox
            // 
            this._Parola_textBox.Location = new System.Drawing.Point(142, 97);
            this._Parola_textBox.Name = "_Parola_textBox";
            this._Parola_textBox.Size = new System.Drawing.Size(206, 26);
            this._Parola_textBox.TabIndex = 5;
            // 
            // kullaniciAdi_textBox
            // 
            this.kullaniciAdi_textBox.Location = new System.Drawing.Point(142, 34);
            this.kullaniciAdi_textBox.Name = "kullaniciAdi_textBox";
            this.kullaniciAdi_textBox.Size = new System.Drawing.Size(206, 26);
            this.kullaniciAdi_textBox.TabIndex = 6;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.PaleGreen;
            this.Login_button.Location = new System.Drawing.Point(12, 268);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(133, 37);
            this.Login_button.TabIndex = 7;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Kullanıcılar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.ControlBox = false;
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.kullaniciAdi_textBox);
            this.Controls.Add(this._Parola_textBox);
            this.Controls.Add(this._kullaniciTürü_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Kullanıcılar";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Kullanıcılar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _kullaniciTürü_comboBox;
        private System.Windows.Forms.TextBox _Parola_textBox;
        private System.Windows.Forms.TextBox kullaniciAdi_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_button;
    }
}