﻿namespace WindowsFormsAppSelll.KULLANICI
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._Parola_textBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdi_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(359, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-2, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola :";
            // 
            // _Parola_textBox
            // 
            this._Parola_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this._Parola_textBox.Location = new System.Drawing.Point(176, 86);
            this._Parola_textBox.Name = "_Parola_textBox";
            this._Parola_textBox.PasswordChar = '*';
            this._Parola_textBox.Size = new System.Drawing.Size(162, 26);
            this._Parola_textBox.TabIndex = 1;
            this._Parola_textBox.TextChanged += new System.EventHandler(this._Parola_textBox_TextChanged);
            // 
            // kullaniciAdi_textBox
            // 
            this.kullaniciAdi_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.kullaniciAdi_textBox.Location = new System.Drawing.Point(176, 28);
            this.kullaniciAdi_textBox.Name = "kullaniciAdi_textBox";
            this.kullaniciAdi_textBox.Size = new System.Drawing.Size(162, 26);
            this.kullaniciAdi_textBox.TabIndex = 0;
            this.kullaniciAdi_textBox.TextChanged += new System.EventHandler(this.kullaniciAdi_textBox_TextChanged);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.PaleGreen;
            this.Login_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.Login_button.Location = new System.Drawing.Point(2, 186);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(121, 40);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "GİRİŞ";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(172, 164);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 22);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş işlemleri";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(355, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Parolayı göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 307);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.kullaniciAdi_textBox);
            this.Controls.Add(this._Parola_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KullaniciGiris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "KullaniciGiris";
            this.Load += new System.EventHandler(this.Kullanıcılar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _Parola_textBox;
        private System.Windows.Forms.TextBox kullaniciAdi_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}