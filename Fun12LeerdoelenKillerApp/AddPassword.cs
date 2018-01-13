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
    public partial class AddPassword : Form
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void BtnAddPassword_Click(object sender, EventArgs e)
        {
            string _domain = BmtbDomainAdd.Text;
            string _username = BmtbUsernameAdd.Text;
            string _password = BmtbPasswordAdd.Text;

            bool[] flags = { false, false, false};
            if (!string.IsNullOrEmpty(_domain))
            {
                flags[0] = true;
            }
            if (!string.IsNullOrEmpty(_username))
            {
                flags[1] = true;
            }
            if (!string.IsNullOrEmpty(_password))
            {
                flags[2] = true;
            }
            if (flags.All<bool>(x => x))
            {
                int tempID = Glob.GetLastId() + 1;
                DataRow dr = new DataRow(_domain, _username, _password,DateTime.Now, tempID);
                Glob.SaveData(dr);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fil in all fields");
            }
            
        }

        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = Glob.CreatePassword();
            BmtbPasswordAdd.Text = generatedPassword;
            Clipboard.SetText(generatedPassword);
        }

        private void CbShowPassword_OnChange(object sender, EventArgs e)
        {
            if (CbShowPassword.Checked)
                BmtbPasswordAdd.isPassword = false;
            else
                BmtbPasswordAdd.isPassword = true;
        }
    }
}
