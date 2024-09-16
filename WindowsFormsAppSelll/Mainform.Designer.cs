namespace WindowsFormsAppSelll
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this._R_button = new System.Windows.Forms.Button();
            this._D_button = new System.Windows.Forms.Button();
            this._H_button = new System.Windows.Forms.Button();
            this._P_button = new System.Windows.Forms.Button();
            this._Formturu_label = new System.Windows.Forms.Label();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _R_button
            // 
            this._R_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this._R_button.Location = new System.Drawing.Point(33, 221);
            this._R_button.Name = "_R_button";
            this._R_button.Size = new System.Drawing.Size(122, 39);
            this._R_button.TabIndex = 0;
            this._R_button.Text = "Randevular";
            this._R_button.UseVisualStyleBackColor = false;
            this._R_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _D_button
            // 
            this._D_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this._D_button.Location = new System.Drawing.Point(203, 221);
            this._D_button.Name = "_D_button";
            this._D_button.Size = new System.Drawing.Size(116, 39);
            this._D_button.TabIndex = 1;
            this._D_button.Text = "Doktorlar";
            this._D_button.UseVisualStyleBackColor = false;
            this._D_button.Click += new System.EventHandler(this._D_button_Click);
            // 
            // _H_button
            // 
            this._H_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this._H_button.Location = new System.Drawing.Point(388, 222);
            this._H_button.Name = "_H_button";
            this._H_button.Size = new System.Drawing.Size(118, 38);
            this._H_button.TabIndex = 2;
            this._H_button.Text = "Hastalar";
            this._H_button.UseVisualStyleBackColor = false;
            this._H_button.Click += new System.EventHandler(this._H_button_Click);
            // 
            // _P_button
            // 
            this._P_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this._P_button.Location = new System.Drawing.Point(575, 221);
            this._P_button.Name = "_P_button";
            this._P_button.Size = new System.Drawing.Size(117, 39);
            this._P_button.TabIndex = 3;
            this._P_button.Text = "Personeller";
            this._P_button.UseVisualStyleBackColor = false;
            this._P_button.Click += new System.EventHandler(this._P_button_Click);
            // 
            // _Formturu_label
            // 
            this._Formturu_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Formturu_label.BackColor = System.Drawing.SystemColors.Window;
            this._Formturu_label.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Formturu_label.Location = new System.Drawing.Point(150, 121);
            this._Formturu_label.Name = "_Formturu_label";
            this._Formturu_label.Size = new System.Drawing.Size(421, 47);
            this._Formturu_label.TabIndex = 4;
            this._Formturu_label.Text = "FORM TÜRÜNÜ SEÇİNİZ";
            this._Formturu_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._Formturu_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.Location = new System.Drawing.Point(582, 378);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(110, 37);
            this._Vazgec_button.TabIndex = 5;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = true;
            this._Vazgec_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 464);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._Formturu_label);
            this.Controls.Add(this._P_button);
            this.Controls.Add(this._H_button);
            this.Controls.Add(this._D_button);
            this.Controls.Add(this._R_button);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _R_button;
        private System.Windows.Forms.Button _D_button;
        private System.Windows.Forms.Button _H_button;
        private System.Windows.Forms.Button _P_button;
        private System.Windows.Forms.Label _Formturu_label;
        private System.Windows.Forms.Button _Vazgec_button;
    }
}