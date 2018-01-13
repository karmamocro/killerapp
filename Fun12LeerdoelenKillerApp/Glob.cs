using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun12LeerdoelenKillerApp
{
    public static class Glob
    {
        /// <summary>
        /// Lijst van alle datarows
        /// </summary>
        public static List<DataRow> Datas = new List<DataRow>();

        /// <summary>
        /// Informatie over de huidige ingelogde gebruiker
        /// </summary>
        public static User CurrentLoggedInUser { get; private set; }

        /// <summary>
        /// Wanneer debugmode op true staat dan hoeft er niet ingelgod te worden
        /// </summary>
        public static bool DebugMode = false;

        /// <summary>
        /// public setting voor de snelheid van de screen animatie
        /// </summary>
        public static int ScreenChangeSpeed = 20;

        // Created for random password method
        private static Random rnd;

        /// <summary>
        /// Zet de huidige gebruiker
        /// </summary>
        /// <param name="LoggedInUser"></param>
        public static void SetCurrentUser(User LoggedInUser)
        {
            CurrentLoggedInUser = LoggedInUser;
        }

        /// <summary>
        /// krijgt een datarow doormiddel van de id opte geven
        /// </summary>
        /// <param name="datarowid"></param>
        /// <returns></returns>
        public static DataRow GetDataByID(int _ID)
        {
            return (Datas.Where(row => row.ID == _ID)).First();
        }


        /// <summary>
        /// krijgt de laatste id van de gegevensrow
        /// </summary>
        /// <returns></returns>
        public static int GetLastId()
        {
            int highestID = 1;
            foreach (DataRow dr in Datas)
            {
                if (dr.ID > highestID)
                {
                    highestID = dr.ID;
                }
            }
            return highestID;
        }


        /// <summary>
        /// Slaat de gegevens op
        /// </summary>
        /// <param name="_dr"></param>
        public static void SaveData(DataRow _dr)
        {
            Datas.Add(_dr);
            //zet gegevens in de database en krijgt een id terug
            string query = $"INSERT INTO gegevens (domain, username, password, dateCreated, gebruiker_fk) VALUES('{_dr.Domain}', '{_dr.Username}', '{_dr.Password}', '{_dr.DateCreated}', {CurrentLoggedInUser.ID}) SELECT SCOPE_IDENTITY() as id";
            DataRowCollection data = Database.GetData(query);
            int realId = Convert.ToInt32(data[0][0]);
            _dr.UpdateId(realId);
        }


        /// <summary>
        /// verwijdert een rij uit de database en uit de lijst
        /// </summary>
        /// <param name="_dr"></param>
        public static void DeleteRow(DataRow _dr)
        {
            // verwijdert de rij uit de database
            Datas.Remove(_dr);
            string query = $"DELETE FROM gegevens WHERE iddata = {_dr.ID}";
            Database.InsertOrUpdateOrDelete(query);
        }


        /// <summary>
        /// Checking the login state
        /// </summary>
        /// <param name="username of loggedin person"></param>
        /// <param name="password of loggedin person"></param>
        /// <returns></returns>
        public static bool CheckLogin(string _username, string _password)
        {
            try
            {
                // krijgt de waarde terug van de gematchte username en wachtwoord wanneer deze er is  + zijn gebruikers id en generetion length
                string query = $"SELECT count(*), gebruikerid, gen_length FROM gebruiker WHERE username = '{_username}' AND password = '{_password}' GROUP BY gebruikerid, gen_length";
                DataRowCollection data = Database.GetData(query);
                if (Convert.ToInt32(data[0][0]) >= 1)
                {
                    Datas.Clear();

                    User loggedInUser = new User(
                        _username, 
                        _password, 
                        DateTime.Now, 
                        Convert.ToInt32(data[0][1]),
                        Convert.ToInt32(data[0][2])
                    );
                    CurrentLoggedInUser = loggedInUser;

                    // Selecteerd alle gegevens van de ingelogde gebruiker
                    string qry2 = $"SELECT * FROM gegevens WHERE gebruiker_fk = {CurrentLoggedInUser.ID}";
                    DataRowCollection dataRows = Database.GetData(qry2);
                    foreach (System.Data.DataRow item in dataRows)
                    {
                         DataRow newRow = new DataRow(
                            item.Field<String>("domain"),
                            item.Field<String>("username"),
                            item.Field<String>("password"),
                            item.Field<DateTime>("dateCreated"),
                            item.Field<Int32>("iddata")
                        );
                        Datas.Add(newRow);
                    }
                    return true;
                }else
                    return false;
            }
            #region Exceptions
            catch (System.Data.SqlClient.SqlException SE)
            {
                return BadExceptionHandler(SE.Message);
            }
            catch (InvalidOperationException IOE)
            {
                return BadExceptionHandler(IOE.Message);
            }
            catch (IndexOutOfRangeException IORE)
            {
                return BadExceptionHandler(/*IORE+*/"No User found for those login credentials");
            }
            #endregion
        }


        /// <summary>
        /// Outputs a message in a messagebox with the given message and returns false;
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        private static bool BadExceptionHandler(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
            return false;
        }


        /// <summary>
        /// genereert een wachtwoord met een lengte die ingesteld is door de gebruiker
        /// </summary>
        /// <returns></returns>
        public static string CreatePassword()
        {
            int length = (CurrentLoggedInUser.GenLength > 0) ? CurrentLoggedInUser.GenLength: 11;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder res = new StringBuilder();
            rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }


        /// <summary>
        /// controleert of er een match is tussen de gegeven source en de gegven pattroon
        /// </summary>
        /// <param name="source"></param>
        /// <param name="patrtern"></param>
        /// <returns></returns>
        public static bool maybeMatch(string source, string patternX)
        {
            string pattern = Regex.Escape(patternX.ToLower());
            string sentence = source.ToLower();
            foreach (Match match in Regex.Matches(sentence, pattern))
            {
                return true;
            }
            return false;
        }

        public static int ReturnAmountUsers()
        {
            int userAmount = 0;
            try
            {
                // Krijgt het aantal gebruikers terug
                string query = $"SELECT count(gebruikerid) FROM gebruiker";
                DataRowCollection data = Database.GetData(query);
                userAmount = Convert.ToInt32(data[0][0]);

                return userAmount;
            }
            catch (IndexOutOfRangeException iore)
            {

                return userAmount;
            }

        }

        public static int ReturnAmountDataRows()
        {
            int dataAmount = 0;
            try
            {
                // Krijgt het aantal datagegevens terug
                string query = $"SELECT count(iddata) FROM gegevens";
                DataRowCollection data = Database.GetData(query);
                dataAmount = Convert.ToInt32(data[0][0]);

                return dataAmount;
            }
            catch (IndexOutOfRangeException iore)
            {

                return dataAmount;
            }

        }

        public static int ReturnAmountPasswordMatch()
        {
            int matchAmount = 0;
            try
            {
                // krijgt de meest gematchte wachtwoord aantal
                string query = $"SELECT top 1 count([password]) as num_pass, password FROM gebruiker as Main WHERE password in (SELECT [password] FROM gebruiker as Sub WHERE Main.password = Sub.password) group by [password]  ;";
                DataRowCollection data = Database.GetData(query);
                matchAmount = Convert.ToInt32(data[0][0]);

                return matchAmount;
            }
            catch (IndexOutOfRangeException iore)
            {

                return matchAmount;
            }

        }

        internal static string ReturnLongestUsernameMostRights()
        {
            string longestUsername = "NULL";
            try
            {
                // Krijgt de langste username met de powerlevel en name 
                string query = $"SELECT username, powerlevel, name FROM gebruiker as GMain  INNER JOIN macht as M ON GMain.gebruikerid = M.gebruikerfk INNER JOIN power as P ON m.powerfk = p.idpower WHERE LEN(GMain.username) = (select MAX(LEN(username)) FROM gebruiker AS Gsub)";
                DataRowCollection data = Database.GetData(query);
                longestUsername = $"{Convert.ToString(data[0][0])} with powerlevel {Convert.ToString(data[0][1])} named with the title {Convert.ToString(data[0][2])}";

                return longestUsername ;
            }
            catch (IndexOutOfRangeException iore)
            {
                return longestUsername;
            }
            
        }
    }
}
