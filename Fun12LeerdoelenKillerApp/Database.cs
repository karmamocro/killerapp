using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12LeerdoelenKillerApp
{
    public class Database
    {

        private static string connectionString = "Data Source=DESKTOP-UF0PRTR;Initial Catalog=funTest;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        /// Krijgt data van de server en stuurt een DataRowCollection terug
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataRowCollection GetData(string sql)
        {
            string query = sql;
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }

        /// <summary>
        /// Voert een query uit alleen de insert, update en delete statements zijn hierbij supported.
        /// </summary>
        /// <param name="query"></param>
        public static void InsertOrUpdateOrDelete(string query)
        {
            DataRowCollection data = Database.GetData(query);
        }

        public override string ToString()
        {
            return $"{connectionString}";
        }
    }
}
