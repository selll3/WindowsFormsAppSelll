namespace WindowsFormsAppSelll
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this._DOK_button1 = new System.Windows.Forms.Button();
            this._RANDE_button2 = new System.Windows.Forms.Button();
            this._hastalar_button = new System.Windows.Forms.Button();
            this._PERS_button4 = new System.Windows.Forms.Button();
            this._Vazgec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "BİR FORM SEÇİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _DOK_button1
            // 
            this._DOK_button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this._DOK_button1.Location = new System.Drawing.Point(12, 92);
            this._DOK_button1.Name = "_DOK_button1";
            this._DOK_button1.Size = new System.Drawing.Size(134, 38);
            this._DOK_button1.TabIndex = 1;
            this._DOK_button1.Text = "DOKTORLAR";
            this._DOK_button1.UseVisualStyleBackColor = false;
            this._DOK_button1.Click += new System.EventHandler(this._DOK_button1_Click);
            // 
            // _RANDE_button2
            // 
            this._RANDE_button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this._RANDE_button2.Location = new System.Drawing.Point(12, 154);
            this._RANDE_button2.Name = "_RANDE_button2";
            this._RANDE_button2.Size = new System.Drawing.Size(134, 38);
            this._RANDE_button2.TabIndex = 2;
            this._RANDE_button2.Text = "RANDEVULAR";
            this._RANDE_button2.UseVisualStyleBackColor = false;
            this._RANDE_button2.Click += new System.EventHandler(this._RANDE_button2_Click);
            // 
            // _hastalar_button
            // 
            this._hastalar_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this._hastalar_button.Location = new System.Drawing.Point(12, 223);
            this._hastalar_button.Name = "_hastalar_button";
            this._hastalar_button.Size = new System.Drawing.Size(134, 38);
            this._hastalar_button.TabIndex = 3;
            this._hastalar_button.Text = "HASTALAR";
            this._hastalar_button.UseVisualStyleBackColor = false;
            this._hastalar_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // _PERS_button4
            // 
            this._PERS_button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this._PERS_button4.Location = new System.Drawing.Point(12, 289);
            this._PERS_button4.Name = "_PERS_button4";
            this._PERS_button4.Size = new System.Drawing.Size(134, 38);
            this._PERS_button4.TabIndex = 4;
            this._PERS_button4.Text = "PERSONEL";
            this._PERS_button4.UseVisualStyleBackColor = false;
            this._PERS_button4.Click += new System.EventHandler(this._PERS_button4_Click);
            // 
            // _Vazgec_button
            // 
            this._Vazgec_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Vazgec_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._Vazgec_button.Location = new System.Drawing.Point(17, 384);
            this._Vazgec_button.Name = "_Vazgec_button";
            this._Vazgec_button.Size = new System.Drawing.Size(134, 38);
            this._Vazgec_button.TabIndex = 21;
            this._Vazgec_button.Text = "VAZGEÇ";
            this._Vazgec_button.UseVisualStyleBackColor = false;
            this._Vazgec_button.Click += new System.EventHandler(this._Vazgec_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(327, 467);
            this.ControlBox = false;
            this.Controls.Add(this._Vazgec_button);
            this.Controls.Add(this._PERS_button4);
            this.Controls.Add(this._hastalar_button);
            this.Controls.Add(this._RANDE_button2);
            this.Controls.Add(this._DOK_button1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button _DOK_button1;
        public System.Windows.Forms.Button _RANDE_button2;
        public System.Windows.Forms.Button _hastalar_button;
        public System.Windows.Forms.Button _PERS_button4;
        public System.Windows.Forms.Button _Vazgec_button;
    }
}