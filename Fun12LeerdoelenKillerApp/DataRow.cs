using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12LeerdoelenKillerApp
{
    public class DataRow
    {
        public string Domain { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime DateCreated { get; private set; }
        public int ID { get; private set; }

        public DataRow(string Domain, string Username, string Password, DateTime DateCreated, int ID)
        {
            this.Domain = Domain;
            this.Username = Username;
            this.Password = Password;
            this.DateCreated = DateCreated;
            this.ID = ID;
        }

        /// <summary>
        /// update de id van de datarow
        /// </summary>
        /// <param name="ID"></param>
        public void UpdateId(int ID)
        {
            this.ID = ID;
        }

        public override string ToString()
        {
            return $"It's for the Domain: {Domain} with username: {Username}";
        }


    }
}
