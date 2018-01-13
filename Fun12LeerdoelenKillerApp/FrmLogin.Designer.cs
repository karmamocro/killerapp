namespace Fun12LeerdoelenKillerApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TbUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblRegister = new System.Windows.Forms.Label();
            this.Lblerr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbUsername
            // 
            this.TbUsername.BorderColorFocused = System.Drawing.Color.Blue;
            this.TbUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbUsername.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TbUsername.BorderThickness = 3;
            this.TbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbUsername.isPassword = false;
            this.TbUsername.Location = new System.Drawing.Point(35, 46);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(370, 44);
            this.TbUsername.TabIndex = 0;
            this.TbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // TbPassword
            // 
            this.TbPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.TbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TbPassword.BorderThickness = 3;
            this.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbPassword.isPassword = true;
            this.TbPassword.Location = new System.Drawing.Point(38, 116);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(370, 44);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Activecolor = System.Drawing.Color.SteelBlue;
            this.BtnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 0;
            this.BtnLogin.ButtonText = "Login";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Iconimage")));
            this.BtnLogin.Iconimage_right = null;
            this.BtnLogin.Iconimage_right_Selected = null;
            this.BtnLogin.Iconimage_Selected = null;
            this.BtnLogin.IconMarginLeft = 0;
            this.BtnLogin.IconMarginRight = 0;
            this.BtnLogin.IconRightVisible = true;
            this.BtnLogin.IconRightZoom = 0D;
            this.BtnLogin.IconVisible = true;
            this.BtnLogin.IconZoom = 90D;
            this.BtnLogin.IsTab = false;
            this.BtnLogin.Location = new System.Drawing.Point(41, 190);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.SteelBlue;
            this.BtnLogin.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(364, 48);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblRegister.Location = new System.Drawing.Point(41, 256);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(79, 13);
            this.LblRegister.TabIndex = 6;
            this.LblRegister.Text = "Or register here";
            this.LblRegister.Click += new System.EventHandler(this.LblRegister_Click);
            // 
            // Lblerr
            // 
            this.Lblerr.AutoSize = true;
            this.Lblerr.ForeColor = System.Drawing.Color.Red;
            this.Lblerr.Location = new System.Drawing.Point(41, 174);
            this.Lblerr.Name = "Lblerr";
            this.Lblerr.Size = new System.Drawing.Size(0, 13);
            this.Lblerr.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 290);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Lblerr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbUsername);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.Text = "Login KillerApp";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox TbUsername;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbPassword;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label Lblerr;
    }
}