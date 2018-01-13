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
    public partial class FrmRegister : Form
    {
        private string username;
        private string password;
        private string passwordVerify;

        public FrmRegister()
        {
            InitializeComponent();
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            username = BmtbUsernameRegister.Text;
            password = BmtbPasswordRegister.Text;
            passwordVerify = BmtbPasswordVerifyRegister.Text;
            bool[] flags = { false, false, false };// hiermee controleer ik of alle velde leeg zijn (ik wou een keer wat unieks proberen)
            if (!string.IsNullOrEmpty(username))
            {
                flags[0] = true;
            }
            if (!string.IsNullOrEmpty(password))
            {
                flags[1] = true;
            }
            if (!string.IsNullOrEmpty(passwordVerify))
            {
                flags[2] = true;
            }
            if (flags.All<bool>(x => x))
            {
                if (password == passwordVerify)
                {
                    LblError.Text = "";
                    // Vult gegevens in van de geregistreerde persoon in de gebruikers tabel en geeft de id terug
                    string query = $"INSERT INTO gebruiker (username, password, gen_length) VALUES('{username}', '{password}', 11) SELECT SCOPE_IDENTITY() as id";
                    DataRowCollection data = Database.GetData(query);
                    Console.WriteLine(data);
                    System.Data.DataRow singleResult = data[0];
                    int createdUserID = Convert.ToInt32(singleResult[0]);
                    User registerdUser = new User(username, password, DateTime.Now, createdUserID, 11);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    LblError.Text = "The Passwords are not matching.";
                }

            }
            else
            {
                LblError.Text = "Not all fields are filled.";
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            LblError.Text = "";
        }

        private void BmtbPasswordVerifyRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister_Click(null, null);
            }
        }
    }
}
