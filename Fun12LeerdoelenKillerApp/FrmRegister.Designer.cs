namespace Fun12LeerdoelenKillerApp
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BmtbPasswordVerifyRegister = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BmtbPasswordRegister = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BmtbUsernameRegister = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Millionaire DEMO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Register";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.BorderRadius = 0;
            this.BtnRegister.ButtonText = "Register";
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegister.Iconimage")));
            this.BtnRegister.Iconimage_right = null;
            this.BtnRegister.Iconimage_right_Selected = null;
            this.BtnRegister.Iconimage_Selected = null;
            this.BtnRegister.IconMarginLeft = 0;
            this.BtnRegister.IconMarginRight = 0;
            this.BtnRegister.IconRightVisible = false;
            this.BtnRegister.IconRightZoom = 0D;
            this.BtnRegister.IconVisible = false;
            this.BtnRegister.IconZoom = 90D;
            this.BtnRegister.IsTab = false;
            this.BtnRegister.Location = new System.Drawing.Point(16, 337);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRegister.selected = false;
            this.BtnRegister.Size = new System.Drawing.Size(403, 48);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegister.Textcolor = System.Drawing.Color.White;
            this.BtnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Verify password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username";
            // 
            // BmtbPasswordVerifyRegister
            // 
            this.BmtbPasswordVerifyRegister.BorderColorFocused = System.Drawing.Color.Blue;
            this.BmtbPasswordVerifyRegister.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbPasswordVerifyRegister.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BmtbPasswordVerifyRegister.BorderThickness = 3;
            this.BmtbPasswordVerifyRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BmtbPasswordVerifyRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BmtbPasswordVerifyRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbPasswordVerifyRegister.isPassword = true;
            this.BmtbPasswordVerifyRegister.Location = new System.Drawing.Point(16, 228);
            this.BmtbPasswordVerifyRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BmtbPasswordVerifyRegister.Name = "BmtbPasswordVerifyRegister";
            this.BmtbPasswordVerifyRegister.Size = new System.Drawing.Size(403, 44);
            this.BmtbPasswordVerifyRegister.TabIndex = 2;
            this.BmtbPasswordVerifyRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BmtbPasswordVerifyRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BmtbPasswordVerifyRegister_KeyDown);
            // 
            // BmtbPasswordRegister
            // 
            this.BmtbPasswordRegister.BorderColorFocused = System.Drawing.Color.Blue;
            this.BmtbPasswordRegister.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbPasswordRegister.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BmtbPasswordRegister.BorderThickness = 3;
            this.BmtbPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BmtbPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BmtbPasswordRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbPasswordRegister.isPassword = true;
            this.BmtbPasswordRegister.Location = new System.Drawing.Point(16, 161);
            this.BmtbPasswordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BmtbPasswordRegister.Name = "BmtbPasswordRegister";
            this.BmtbPasswordRegister.Size = new System.Drawing.Size(403, 44);
            this.BmtbPasswordRegister.TabIndex = 1;
            this.BmtbPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BmtbUsernameRegister
            // 
            this.BmtbUsernameRegister.BorderColorFocused = System.Drawing.Color.Blue;
            this.BmtbUsernameRegister.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbUsernameRegister.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.BmtbUsernameRegister.BorderThickness = 3;
            this.BmtbUsernameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BmtbUsernameRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BmtbUsernameRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BmtbUsernameRegister.isPassword = false;
            this.BmtbUsernameRegister.Location = new System.Drawing.Point(13, 62);
            this.BmtbUsernameRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BmtbUsernameRegister.Name = "BmtbUsernameRegister";
            this.BmtbUsernameRegister.Size = new System.Drawing.Size(406, 44);
            this.BmtbUsernameRegister.TabIndex = 0;
            this.BmtbUsernameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(16, 280);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 17;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 413);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BmtbPasswordVerifyRegister);
            this.Controls.Add(this.BmtbPasswordRegister);
            this.Controls.Add(this.BmtbUsernameRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox BmtbPasswordVerifyRegister;
        private Bunifu.Framework.UI.BunifuMetroTextbox BmtbPasswordRegister;
        private Bunifu.Framework.UI.BunifuMetroTextbox BmtbUsernameRegister;
        private System.Windows.Forms.Label LblError;
    }
}