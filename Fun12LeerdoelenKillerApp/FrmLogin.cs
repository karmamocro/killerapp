using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun12LeerdoelenKillerApp
{
    public partial class FrmLogin : Form
    {
        FrmMain MainForm = new FrmMain();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TbUsername.Text;
            string password = TbPassword.Text;
            string errMessage = "";
            if (Glob.CheckLogin(username,password))
            {
                OpenMainForm();
            }
            else
            {
                errMessage = "Please try again";
            }
            Lblerr.Text = errMessage;
        }

        /// <summary>
        /// Opent de main form en sluit de huidige from
        /// </summary>
        private void OpenMainForm()
        {
            MainForm.Show();
            this.Hide();

        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(null, null);
            }
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {
            FrmRegister RegisterForm = new FrmRegister();
            RegisterForm.ShowDialog();
        }

        async private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Checks the debug mode and determines if the login form should be skipped or not!
            if (Glob.DebugMode == true)
            {
                Glob.CheckLogin("erik", "hans");
                await Task.Delay(1);
                OpenMainForm();
            }
        }
    }
}
