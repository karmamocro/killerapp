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
    public partial class FrmMain : Form
    {
        ListViewItem[] itemsC;
        HashSet<int> indeces;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {
            TbCMain.SelectedTab = TbCMain.TabPages["TbpRegister"];
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            TbCMain.SelectedTab = TbCMain.TabPages["TbpLogin"];
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (TbCMain.SelectedTab != TbCMain.TabPages["TbpSettings"])
            {
                TbCMain.SelectedTab = TbCMain.TabPages["TbpSettings"];

                TmrSettingsNav.Enabled = true;
                TmrSettingsNav.Start();
                TmrSettingsNav.Interval = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (this.Width > 800)
            {
                this.Width -= Glob.ScreenChangeSpeed;
            }
            TmrSettingsNav.Stop();
            TmrSettingsNav.Enabled = false;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (TbCMain.SelectedTab != TbCMain.TabPages["TbpHome"])
            {
                TbCMain.SelectedTab = TbCMain.TabPages["TbpHome"];

                TmrDefaultSizeNav.Enabled = true;
                TmrDefaultSizeNav.Start();
                TmrDefaultSizeNav.Interval = 1;
            }
        }

        private void TmrDefaultSizeNav_Tick(object sender, EventArgs e)
        {
            while (this.Width < 1082)
            {
                this.Width += Glob.ScreenChangeSpeed;
            }
            TmrDefaultSizeNav.Stop();
            TmrDefaultSizeNav.Enabled = false;
        }

        private void BtnAddpassword_Click(object sender, EventArgs e)
        {
            AddPassword adpw = new AddPassword();
            adpw.ShowDialog();
            if (adpw.DialogResult == DialogResult.OK)
            {
                Console.WriteLine("done");
                RefreshDataInList();
                
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            RefreshDataInList();
        }


        /// <summary>
        /// Herlaad alle data in de lisview
        /// </summary>
        private void RefreshDataInList()
        {
            LvPassword.Items.Clear();
            if (Glob.Datas.Count < 1)
            {
                ListViewItem nlvi = new ListViewItem(new [] { "", "No passwords saved yet." });
                LvPassword.Items.Add(nlvi);
            }
            foreach (DataRow data in Glob.Datas)
            {

                ListViewItem lvi = new ListViewItem() { Tag = data};
                lvi.Text = data.ID.ToString();
                lvi.SubItems.Add(data.Domain);
                lvi.SubItems.Add(data.Username);
                lvi.SubItems.Add(data.Password);
                lvi.SubItems.Add(data.DateCreated.ToString());
                LvPassword.Items.Add(lvi);
            }
            itemsC = new ListViewItem[LvPassword.Items.Count];
            LvPassword.Items.CopyTo(itemsC, 0);
        }

        private void BtnLogOut_Click_1(object sender, EventArgs e)
        {
            LogOut();
        }


        /// <summary>
        /// leegt de currentuser in de global variable en brengt je terug naar de login form
        /// </summary>
        private void LogOut()
        {
            Glob.SetCurrentUser(null);
            FrmLogin LoginForm = new FrmLogin();
            LoginForm.Show();
            this.Hide();
        }

        private void TbCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbCMain.SelectedTab == TbCMain.TabPages["TbpSettings"])
            {
                ShowCurrentInformation();
            }
        }

        /// <summary>
        /// Laat alle informatie zien van de gebruiker
        /// </summary>
        private void ShowCurrentInformation()
        {
            NudSettingGeneratePasswordLength.Value = Glob.CurrentLoggedInUser.GenLength;
            BmtbSettingUsername.Text = Glob.CurrentLoggedInUser.Gebruikersnaam;
            BmtbSettingPassword.Text = Glob.CurrentLoggedInUser.Wachtwoord;
        }

        private void BtnApplySettings_Click(object sender, EventArgs e)
        {
            string username = BmtbSettingUsername.Text;
            string password = BmtbSettingPassword.Text;
            int pwGen = (Int32)NudSettingGeneratePasswordLength.Value;
            Glob.CurrentLoggedInUser.ChangeUsername(username);
            Glob.CurrentLoggedInUser.ChangePassword(password);
            Glob.CurrentLoggedInUser.ChangeGenLength(pwGen);

        }

        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPassword = Glob.CreatePassword();
            BmtbGenPassword.Text = generatedPassword;
            Clipboard.SetText(generatedPassword);
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LvPassword.SelectedItems.Count > 0) // checkt of een regel geselecteerd is
                {
                    int index = LvPassword.Items.IndexOf(LvPassword.SelectedItems[0]);
                    DataRow selectedData = (DataRow)LvPassword.SelectedItems[0].Tag;
                    Glob.DeleteRow(selectedData);
                    RefreshDataInList();

                }
            }
            catch (IndexOutOfRangeException _IORE)
            {
                MessageBox.Show("Regel niet gevonden in de data");
            }
            
        }


        /// <summary>
        /// zoek in de listview naar de patroon die opgegeven is
        /// </summary>
        /// <param name="pattern"></param>
        private void SearchInList(string pattern)
        {
            indeces = new HashSet<int>();
            if (pattern.Length > 0)
            {
                for (int i = 0; i < Glob.Datas.Count(); i++)
                {
                    ListViewItem CurrItem = itemsC[i];
                    Console.WriteLine(itemsC[i]);

                    if (Glob.maybeMatch(CurrItem.Text, pattern) || Glob.maybeMatch(CurrItem.SubItems[1].Text, pattern) || Glob.maybeMatch(CurrItem.SubItems[2].Text, pattern))
                    {
                        if (!indeces.Contains(i))
                        {
                            indeces.Add(i);
                        }
                        Console.WriteLine("Index added: " + i);
                        Console.WriteLine("count" + indeces.Count);
                    }
                }

                this.LvPassword.Items.Clear();
                foreach (var index in indeces)
                {
                    Console.WriteLine("The index: " + index + " is in the array");
                    this.LvPassword.Items.Add(itemsC[index]);
                }

            }
            else
            {
                RefreshDataInList();
                indeces.Clear();
                Console.WriteLine("Indces cleared!");
            }
        }

        private void BtnSearchPassword_Click(object sender, EventArgs e)
        {
            SearchInList(BmtbSearch.Text);
        }


        private void BmtbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchInList(BmtbSearch.Text);
        }

        private void CbShowGeneratedPassword_OnChange(object sender, EventArgs e)
        {
            if (CbShowGeneratedPassword.Checked)
            {
                BmtbGenPassword.isPassword = false;
                LvPassword.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
            else
            {
                BmtbGenPassword.isPassword = true;
                LvPassword.Columns[3].Width = 1;

            }
            
        }

        private void LvPassword_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (!CbShowGeneratedPassword.Checked)
            {
                e.Cancel = true;
                e.NewWidth = LvPassword.Columns[e.ColumnIndex].Width;
            }
                
        }

        private void TsmiCopyPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (LvPassword.SelectedItems.Count > 0)
                {
                    DataRow selectedData = (DataRow)LvPassword.SelectedItems[0].Tag;
                    Clipboard.SetText(selectedData.Password);
                }
            }
            catch (IndexOutOfRangeException _IORE)
            {
                MessageBox.Show("Regel niet gevonden in de data");
            }
        }

        private void BtnWeetjes_Click(object sender, EventArgs e)
        {
            if (TbCMain.SelectedTab != TbCMain.TabPages["TbpWeetjes"])
            {
                TbCMain.SelectedTab = TbCMain.TabPages["TbpWeetjes"];

                TmrDefaultSizeNav.Enabled = true;
                TmrDefaultSizeNav.Start();
                TmrDefaultSizeNav.Interval = 1;
            }

            Database DBinstance = new Database(); // used for the weetjes tab to get the tostring overrride method.

            LblLaatsteDataRegel.Text = Glob.Datas.Last().ToString();
            LblHuidigeGebruiker.Text = Glob.CurrentLoggedInUser.ToString();
            LblDatabaseConnectieString.Text = DBinstance.ToString();

            LblAantalGebruikers.Text = Glob.ReturnAmountUsers().ToString();
            LblAantalRegelsOpgeslagen.Text = Glob.ReturnAmountDataRows().ToString();
            LblLongestUsernameWithMostRights.Text = Glob.ReturnLongestUsernameMostRights().ToString();
            LblAantalWachtwoordenMatch.Text = Glob.ReturnAmountPasswordMatch().ToString();
        }
    }
}
