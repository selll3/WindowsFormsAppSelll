namespace WindowsFormsAppSelll.DOKTOR
{
    partial class KullaniciD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciD));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._randevular_button = new System.Windows.Forms.Button();
            this._Hastalar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(18, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "FORM SEÇİNİZ";
            // 
            // _randevular_button
            // 
            this._randevular_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._randevular_button.Location = new System.Drawing.Point(253, 132);
            this._randevular_button.Name = "_randevular_button";
            this._randevular_button.Size = new System.Drawing.Size(137, 41);
            this._randevular_button.TabIndex = 5;
            this._randevular_button.Text = "RANDEVULAR";
            this._randevular_button.UseVisualStyleBackColor = false;
            this._randevular_button.Click += new System.EventHandler(this._randevular_button_Click);
            // 
            // _Hastalar_button
            // 
            this._Hastalar_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._Hastalar_button.Location = new System.Drawing.Point(18, 132);
            this._Hastalar_button.Name = "_Hastalar_button";
            this._Hastalar_button.Size = new System.Drawing.Size(137, 41);
            this._Hastalar_button.TabIndex = 4;
            this._Hastalar_button.Text = "HASTALAR";
            this._Hastalar_button.UseVisualStyleBackColor = false;
            this._Hastalar_button.Click += new System.EventHandler(this._Hastalar_button_Click);
            // 
            // KullaniciD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(407, 332);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._randevular_button);
            this.Controls.Add(this._Hastalar_button);
            this.Name = "KullaniciD";
            this.Text = "KULLANICI (DOKTOR)";
            this.Load += new System.EventHandler(this.KullaniciD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _randevular_button;
        private System.Windows.Forms.Button _Hastalar_button;
    }
}