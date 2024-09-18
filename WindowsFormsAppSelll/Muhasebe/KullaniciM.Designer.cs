namespace WindowsFormsAppSelll.Muhasebe
{
    partial class KullaniciM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciM));
            this.label1 = new System.Windows.Forms.Label();
            this._PERSONELLER_button = new System.Windows.Forms.Button();
            this._Hastalar_button = new System.Windows.Forms.Button();
            this.DOKTORLAR_BUTTON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(150, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORM SEÇİNİZ";
            // 
            // _PERSONELLER_button
            // 
            this._PERSONELLER_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._PERSONELLER_button.Location = new System.Drawing.Point(174, 164);
            this._PERSONELLER_button.Name = "_PERSONELLER_button";
            this._PERSONELLER_button.Size = new System.Drawing.Size(137, 41);
            this._PERSONELLER_button.TabIndex = 4;
            this._PERSONELLER_button.Text = "PERSONELLER";
            this._PERSONELLER_button.UseVisualStyleBackColor = false;
            this._PERSONELLER_button.Click += new System.EventHandler(this._PERSONELLER_button_Click);
            // 
            // _Hastalar_button
            // 
            this._Hastalar_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._Hastalar_button.Location = new System.Drawing.Point(12, 164);
            this._Hastalar_button.Name = "_Hastalar_button";
            this._Hastalar_button.Size = new System.Drawing.Size(137, 41);
            this._Hastalar_button.TabIndex = 3;
            this._Hastalar_button.Text = "HASTALAR";
            this._Hastalar_button.UseVisualStyleBackColor = false;
            this._Hastalar_button.Click += new System.EventHandler(this._Hastalar_button_Click);
            // 
            // DOKTORLAR_BUTTON
            // 
            this.DOKTORLAR_BUTTON.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DOKTORLAR_BUTTON.Location = new System.Drawing.Point(341, 164);
            this.DOKTORLAR_BUTTON.Name = "DOKTORLAR_BUTTON";
            this.DOKTORLAR_BUTTON.Size = new System.Drawing.Size(137, 41);
            this.DOKTORLAR_BUTTON.TabIndex = 6;
            this.DOKTORLAR_BUTTON.Text = "DOKTORLAR";
            this.DOKTORLAR_BUTTON.UseVisualStyleBackColor = false;
            this.DOKTORLAR_BUTTON.Click += new System.EventHandler(this.DOKTORLAR_BUTTON_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(16, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 343);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DOKTORLAR_BUTTON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._PERSONELLER_button);
            this.Controls.Add(this._Hastalar_button);
            this.Name = "KullaniciM";
            this.Text = "KullaniciM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _PERSONELLER_button;
        private System.Windows.Forms.Button _Hastalar_button;
        private System.Windows.Forms.Button DOKTORLAR_BUTTON;
        private System.Windows.Forms.Button button1;
    }
}