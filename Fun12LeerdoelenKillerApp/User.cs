using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12LeerdoelenKillerApp
{
    public class User
    {
        public string Gebruikersnaam { get; private set; }
        public string Wachtwoord { get; private set; }
        public DateTime DateCreated { get; private set; }
        public int ID { get; private set; }

        public int GenLength { get; private set; }

        public User(string Gebruikersnaam, string Wachtwoord, DateTime DateCreated, int ID, int GenLength)
        {
            this.Gebruikersnaam = Gebruikersnaam;
            this.Wachtwoord = Wachtwoord;
            this.DateCreated = DateCreated;
            this.ID = ID;
            this.GenLength = GenLength;
        }

        public void ChangeUsername(string nieuweGebruikersnaam)
        {
            Gebruikersnaam = nieuweGebruikersnaam;
            Database.InsertOrUpdateOrDelete($"UPDATE gebruiker SET username = '{nieuweGebruikersnaam}' WHERE gebruikerid = {Glob.CurrentLoggedInUser.ID}");
        }
        public void ChangePassword(string nieuwePassword)
        {
            Wachtwoord = nieuwePassword;
            Database.InsertOrUpdateOrDelete($"UPDATE gebruiker SET password = '{nieuwePassword}' WHERE gebruikerid = {Glob.CurrentLoggedInUser.ID}");
        }
        public void ChangeGenLength(int nieuweGenLength)
        {
            GenLength = nieuweGenLength;
            Database.InsertOrUpdateOrDelete($"UPDATE gebruiker SET gen_length = {nieuweGenLength} WHERE gebruikerid = {Glob.CurrentLoggedInUser.ID}");
        }

        public override string ToString()
        {
            return $"Logged in with the username: {Gebruikersnaam}";
        }

    }
}
